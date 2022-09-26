using Sampler.Enums;
using Sampler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampler.Models
{
    public class Measurment : IValueMeasurment
    {
        public DateTime MeasurmentTime { get; set; }
        public double MeasurmentValue { get; set; }
        public MeasurmentType Type { get; set; }

    }
}
