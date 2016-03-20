using System.Configuration;
using System.Globalization;

namespace Backend.AppConfigManager
{
    public class AppConfigReader
    {

        public string GetValueFromKeyInAppConfig(string key)
        {
            var value = string.Empty;

            if (!string.IsNullOrEmpty(key))
            {
                var auxValueObject = ConfigurationManager.AppSettings[key];

                if (!object.ReferenceEquals(auxValueObject, null))
                {
                    value = auxValueObject.ToString(CultureInfo.InvariantCulture);
                    //Pueden usar tambien el ToString(); sin la necesidad de usar la sobrecarga
                    //que use en la línea 25.
                }
            }

            return value;

        }




    }
}
