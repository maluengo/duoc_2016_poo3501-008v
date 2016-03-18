using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackend.AppConfigManager
{
    /// <summary>
    /// Doc. 
    /// </summary>
    public class ConfigReader
    {

        /// <summary>
        /// Mi comentario, con 3 /// seguidos.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string ObtenerValorPorIdentificador(string key)
        {
            string valor = default(string);

            //if (key == "")
            //{
                
            //}

            //if (!string.IsNullOrWhiteSpace(key))
            //{
            //    var asdsad = "";
            //    var asdasdasa = "  ";
            //}

            if (!string.IsNullOrEmpty(key))
            {
                //aca, recien me preocupo de obtener el valor desde el config.
                //usando la clase ConfigurationSettings que es, como lo dij
                //en la primera clase el profesor, parte del CLB. 
                var miConfigurador = ConfigurationSettings.AppSettings[key];

                if (!object.ReferenceEquals(miConfigurador, null))
                {
                    valor = miConfigurador.ToString();

                }

                //if (miConfigurador != null)
                //{
                    
                //}

                //if (!miConfigurador.Equals(default(object)))
                //{
                    
                //}


            }


            return valor;  
        }

        public int ObtenerLargo(string value)
        {
            var largo = default(int);

            if (!string.IsNullOrEmpty(value))
            {
                largo = value.Length;
            }

            return largo;

            //return value.Length;
            //return !string.IsNullOrEmpty(value)
            //    ? value.Length : default(int);
        }







    }
}
