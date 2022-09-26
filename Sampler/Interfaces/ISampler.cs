using Sampler.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampler.Interfaces
{
    public interface ISampler
    {
        public Dictionary<MeasurmentType, List<IValueMeasurment>> Sample(
                   DateTime startOfSampling, List<IValueMeasurment> unsampledMeasurments);
    }
}
