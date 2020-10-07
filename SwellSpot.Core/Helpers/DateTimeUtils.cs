
using System;
using System.Collections.Generic;
using System.Text;

namespace SwellSpot.Core.Helpers
{
    public static class DateTimeUtils
    {
        public static string ToDateString(this DateTime dateTime) =>
            dateTime.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
        public static DateTime ToDateTime(this string stringDateTime) =>
            DateTime.Parse(stringDateTime);
    }
}
