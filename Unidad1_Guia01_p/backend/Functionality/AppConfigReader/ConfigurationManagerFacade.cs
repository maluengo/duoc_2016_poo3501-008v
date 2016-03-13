using System.Configuration;
using System.Globalization;
using System.Linq;

namespace backend.Functionality.AppConfigReader
{
    public class ConfigurationManagerFacade
    {
        public string GetAnyValueFromConfigByKey(string key)
        {
            var value = default(string);

            if (!string.IsNullOrEmpty(key))
            {
                if (ConfigurationManager.AppSettings.AllKeys.Any())
                {
                    if (!object.ReferenceEquals(ConfigurationManager.AppSettings[key], null))
                    {
                        value = ConfigurationManager.AppSettings[key].ToString(CultureInfo.InvariantCulture);

                    }
                    
                }
            }


            return value;
        }
    }
}
