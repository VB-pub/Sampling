using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampler.Interfaces
{
    public interface IDateTimeValidator : IValidator
    {
        public bool IsInPeriod();
        public bool IsOutPeriod();
        public bool IsBigger();
        public bool IsSmaller();
        public void SetValues(DateTime current, DateTime compare);
    }
}
