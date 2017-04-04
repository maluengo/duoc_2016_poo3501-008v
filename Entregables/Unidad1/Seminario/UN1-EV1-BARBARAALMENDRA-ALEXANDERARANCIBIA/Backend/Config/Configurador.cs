using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Globalization;

namespace Backend.Config
{
    public class Configurador
    {
        public string GetValueByKeyFromConfig(string key)
        {
            string valueFromConfig = string.Empty;

            if (!string.IsNullOrEmpty(key))
            {

                var auxAppConfig = ConfigurationSettings.AppSettings[key];


                if (!object.ReferenceEquals(auxAppConfig, null))
                {

                    valueFromConfig = auxAppConfig.ToString(CultureInfo.CurrentCulture);
                }

            }

            return valueFromConfig;
        }
}
}
