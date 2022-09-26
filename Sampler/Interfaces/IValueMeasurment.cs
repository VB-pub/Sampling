using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampler.Interfaces
{
    public interface IValueMeasurment : IMeasurment
    {
        public double MeasurmentValue { get; set; }
    }
}
