using System.Configuration;
using System.Globalization;

namespace Backend.Configuration
{
    /// <summary>
    /// ATR: Clase que encapsulará toda la lógica de lectura y manejo de archivos de configuracion. 
    /// </summary>
    public class AppConfigReader
    {
        /// <summary>
        /// ATR: Método que permite obtener el valor 'value' desde al App.Config, a partir de su 'key'
        /// </summary>
        /// <returns></returns>
        public string GetValueByKeyFromConfig(string key)
        {
            string valueFromConfig = string.Empty;

            //Comprobamos que el Key que se paso por parametro sea distinto de NULL o Vacio. 
            if (!string.IsNullOrEmpty(key))
            {
                //Guardamos, en un objeto auxiliar, temporal, el archivo de configuracion segun el key que le hemos pasado por parametro. 
                //Usamos la clase estática ConfigurationSettings, parte de las librerías base del framework. 
                var auxAppConfig = ConfigurationSettings.AppSettings[key];

                //Comprobamos si el objeto auxiliar es distinto de NULL.
                if (!object.ReferenceEquals(auxAppConfig, null))
                {
                    //Como es distinto de null, entonces, obtenemos el valor y se lo asignamos a nuestra variable valueFromConfig
                    //que retornaremos como resultado del método. 
                    valueFromConfig = auxAppConfig.ToString(CultureInfo.CurrentCulture);
                }

            }

            return valueFromConfig;

        }

        /// <summary>
        /// ATR: Método que permite encapsular la lógica de la obtención del tamaño de una cadena de caracteres.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetSizeOfString(string key)
        {
            int size = default(int);

            //Comprobamos que el Key que se paso por parametro sea distinto de NULL o Vacio. 
            if (!string.IsNullOrEmpty(key))
            {
                //Usamos la propiedad del objeto String 'Lenght', el cual retorna en un valor entero el largo de la cadena. 
                size = key.Length;
            }  
                return size;
            
        }

    }
}
