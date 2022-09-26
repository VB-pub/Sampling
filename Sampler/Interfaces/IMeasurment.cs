using Sampler.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampler.Interfaces
{
    public interface IMeasurment
    {
        public MeasurmentType Type { get; set; }
        public DateTime MeasurmentTime { get; set; }
    }
}
