using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3.App.Back.AppConfig
{
    public class AppConfigReader
    {

        public string GetValueFromKey(string key)
        {
            string value = string.Empty;

            if (!string.IsNullOrEmpty(key))
            {
                var auxAppSetting = ConfigurationManager.AppSettings[key];

                if (!object.ReferenceEquals(auxAppSetting, null))
                {
                    value = auxAppSetting.ToString(CultureInfo.InvariantCulture);
                }

            }

            return value;

        }

    }
}
