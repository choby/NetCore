using System;

namespace Inman.Infrastructure.Common
{
    public class RangeDateTimeFilter
    {
        private readonly string _datetimeFormat = "yyyy-MM-dd hh:mm:ss";

        public RangeDateTimeFilter()
        {

        }

        public RangeDateTimeFilter(string datetimeFormat)
        {
            _datetimeFormat = datetimeFormat;
        }

        public DateTime? From { get; private set; }

        public string FromStr
        {
            get
            {
                if (From.HasValue)
                {
                    return From.Value.ToString(_datetimeFormat);
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                DateTime datetime;
                if (DateTime.TryParse(value, out datetime))
                {
                    From = datetime;
                }
                else
                {
                    From = null;
                }

            }
        }

        public DateTime? To { get; private set; }

        public string ToStr
        {
            get
            {
                if (To.HasValue)
                {
                    return To.Value.ToString(_datetimeFormat);
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                DateTime datetime;
                if (DateTime.TryParse(value, out datetime))
                {
                    To = datetime;
                }
                else
                {
                    To = null;
                }
            }
        }
    }
}
