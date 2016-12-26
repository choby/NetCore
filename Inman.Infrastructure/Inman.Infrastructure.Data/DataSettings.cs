using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Data
{
    public class DataSettings
    {
        public DataSettings()
        {
            RawDataSettings = new Dictionary<string, string>();
        }

        public string DataProvider { get; set; }

        public string DataConnectionString { get; set; }

        public IDictionary<string, string> RawDataSettings { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(this.DataProvider) &&
                    !string.IsNullOrEmpty(this.DataConnectionString);
        }
    }
}
