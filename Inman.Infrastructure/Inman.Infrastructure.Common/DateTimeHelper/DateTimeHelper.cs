using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Common
{
    public partial class DateTimeHelper : IDateTimeHelper
    {
        public Int64 ConvertToInt(DateTime dt)
        {
            DateTime dtStart = new DateTime(1970, 1, 1).ToLocalTime(); //TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            return Convert.ToInt64(Math.Floor(dt.Subtract(dtStart).TotalSeconds));
        }

        public DateTime ConvertToDateTime(Int64 number)
        {
            DateTime dtStart = new DateTime(1970, 1, 1).ToLocalTime();//TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            return dtStart.AddSeconds(number);
        }
    }
}
