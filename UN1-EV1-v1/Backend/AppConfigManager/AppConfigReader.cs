using System;
using System.Configuration;
using System.Globalization;

namespace Backend.AppConfigManager
{
    public class AppConfigReader
    {

        /// <summary>
        /// Obtiene un valor desde App.Config a partir de su Key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetValueFromKeyInAppConfig(string key)
        {
            var value = string.Empty;

            if (!string.IsNullOrEmpty(key))
            {
                var auxValueObject = ConfigurationManager.AppSettings[key];

                if (!object.ReferenceEquals(auxValueObject, null))
                {
                    value = auxValueObject.ToString(CultureInfo.InvariantCulture);
                }
            }

            return value;

        }

        /// <summary>
        /// Comprueba si, a partir de un key ingresado, existe o no dicho valor. 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool CheckIfValueExistInConfig(string key, string valueToCompare)
        {
            var isEqual = false;

            if (!string.IsNullOrEmpty(valueToCompare) && (!string.IsNullOrEmpty(key)))
            {
                var auxValueFromCOnfig = GetValueFromKeyInAppConfig(key);

                if (!string.IsNullOrEmpty(auxValueFromCOnfig))
                {
                    isEqual = string.Equals(valueToCompare, auxValueFromCOnfig, StringComparison.CurrentCultureIgnoreCase);
                }

            }
               
            return isEqual;

        }








    }
}
