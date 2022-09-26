using Sampler.Enums;
using Sampler.Models;
using Sampler.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sampler.Interfaces;

namespace Sampler
{
    public class DefaultSampler : ISampler
    {
        private readonly IDateTimeValidator _validator;

        public DefaultSampler(IDateTimeValidator validator)
        {
            this._validator = validator;
        }

        public Dictionary<MeasurmentType, List<IValueMeasurment>> Sample(
            DateTime startOfSampling, List<IValueMeasurment> unsampledMeasurments)
        {
            Dictionary<MeasurmentType, List<IValueMeasurment>> dict = new();

            foreach (Measurment m in unsampledMeasurments)
            {
                if (startOfSampling > m.MeasurmentTime)
                    continue;

                if (dict.TryAdd(m.Type, new List<IValueMeasurment>()))
                    dict[m.Type].Add(m);
                else
                    TryAdd(m, dict[m.Type]);
            }

            return dict;
        }

        private bool TryAdd(Measurment m, List<IValueMeasurment> listMeasurment)
        {
            try
            {
                var enumerator = listMeasurment.GetEnumerator();
                int i = 0;
                while (enumerator.MoveNext())
                {
                    _validator.SetValues(m.MeasurmentTime, enumerator.Current.MeasurmentTime);

                    bool skip;
                    bool replace;
                    if (_validator.IsValid(out skip, out replace))
                    {
                        if (replace) listMeasurment.Remove(enumerator.Current);
                        listMeasurment.Insert(i, m);
                        return true;
                    }
                    else if (skip)
                        return false;
                    i++;
                }

                listMeasurment.Add(m);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
