using System;
using System.Threading;
using Zeats.Legacy.StringExtensions;

namespace Zeats.Legacy.DayOfWeekExtensions
{
    public static class DayNameExtension
    {
        public static string DayName(this DayOfWeek dayOfWeek)
        {
            return Thread.CurrentThread.CurrentCulture.DateTimeFormat.GetDayName(dayOfWeek).FirstCharToUpper();
        }
    }
}