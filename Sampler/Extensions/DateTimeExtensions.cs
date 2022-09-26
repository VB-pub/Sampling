using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampler.Extensions
{
    internal static class DateTimeExtensions
    {
        public static bool Between(this DateTime current, DateTime min, DateTime max) =>
            current > min && current < max;

        public static bool SamePeriod(this DateTime current, DateTime compare, TimeSpan span) =>
            current.Ticks / span.Ticks == compare.Ticks / span.Ticks;

    }
}
