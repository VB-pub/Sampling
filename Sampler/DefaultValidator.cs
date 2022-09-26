using Sampler.Interfaces;
using Sampler.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampler
{
    public class DefaultValidator : IDateTimeValidator
    {
        private readonly int periodInMinutes;

        private DateTime current;
        private DateTime compare;

        public DefaultValidator(int periodInMinutes)
        {
            this.periodInMinutes = periodInMinutes;
        }

        public void SetValues(DateTime current, DateTime compare)
        {
            this.current = current;
            this.compare = compare;
        }

        public bool IsInPeriod() => current.SamePeriod(compare, TimeSpan.FromMinutes(periodInMinutes));

        public bool IsOutPeriod() => !current.SamePeriod(compare, TimeSpan.FromMinutes(periodInMinutes));

        public bool IsBigger() => current.CompareTo(compare) > 0;

        public bool IsSmaller() => current.CompareTo(compare) < 0;

        public bool IsEqual() => current.Equals(compare);        

        public bool IsValid(out bool skip, out bool replace)
        {
            skip = IsInPeriod() && IsSmaller() ||
                IsEqual();
            replace = IsInPeriod() && IsBigger();

            return replace || (IsOutPeriod() && IsSmaller());
        }
    }
}
