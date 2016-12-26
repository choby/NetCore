using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Hosting;

namespace Inman.Infrastructure.Data
{
    public class DataSettingsManager
    {
        protected const char separator = ':';
        protected const string filename = "Settings.txt";

        protected virtual string MapPath(string path)
        {
            if (HostingEnvironment.IsHosted)
            {
                //hosted
                return HostingEnvironment.MapPath(path);
            }
            else
            {
                string baseDiretory = AppDomain.CurrentDomain.BaseDirectory;
                path = path.Replace("~/", "").TrimStart('/').Replace('/', '\\');
                return Path.Combine(baseDiretory, path);
            }
        }

        protected virtual DataSettings ParseSettings(string text)
        {
            var shellSettings = new DataSettings();
            if (string.IsNullOrEmpty(text))
                return shellSettings;

            var settings = new List<string>();
            using (var reader = new StringReader(text))
            {
                string str;
                while ((str = reader.ReadLine()) != null)
                    settings.Add(str);
            }

            foreach (var setting in settings)
            {
                var separatorIndex = setting.IndexOf(separator);
                if (separatorIndex == -1)
                {
                    continue;
                }
                string key = setting.Substring(0, separatorIndex).Trim();
                string value = setting.Substring(separatorIndex + 1).Trim();

                switch (key)
                {
                    case "DataProvider":
                        shellSettings.DataProvider = value;
                        break;
                    case "DataConnectionString":
                        shellSettings.DataConnectionString = value;
                        break;
                    default:
                        shellSettings.RawDataSettings.Add(key, value);
                        break;
                }
            }
            return shellSettings;
        }

        public virtual string ComposeSettings(DataSettings settings)
        {
            if (settings == null)
                return "";

            return string.Format("DataProvider: {0}{2}DataConnectionString:{1}{2}",
                                 settings.DataProvider,
                                 settings.DataConnectionString,
                                 Environment.NewLine);
        }

        public virtual DataSettings LoadSettings(string filePath = null)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                filePath = Path.Combine(MapPath("~/App_Data/"), filename);
            }
            if (File.Exists(filePath))
            {
                string text = File.ReadAllText(filePath);
                return ParseSettings(text);
            }
            else
            {
                return new DataSettings();
            }
        }

        public virtual void SaveSettings(DataSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException("settings");

            string filePath = Path.Combine(MapPath("~/App_Data/"), filename);
            if (!File.Exists(filePath))
            {
                using (File.Create(filePath))
                {

                }
            }
            var text = ComposeSettings(settings);
            File.WriteAllText(filePath, text);
        }
    }
}
