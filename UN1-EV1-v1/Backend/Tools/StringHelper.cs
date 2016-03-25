using System; 

namespace Backend.Tools
{
    public class StringHelper
    {

        /// <summary>
        /// Permite separar un string, a partir de un caracter definido.  Además, retorna
        /// el valor final según el indice (ejemplo: value-sdas, separa por - y retornará
        /// según el index la primera o segunda parte de la cadena. 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="valueToSeparate"></param>
        /// <param name="chars"></param>
        /// <returns></returns>
        public string GetSplitStringByIndex(int index, string valueToSeparate, string chars)
        {
            var finalValue = string.Empty;

            if (!string.IsNullOrEmpty(valueToSeparate) && !string.IsNullOrEmpty(chars))
            {                                                                                                                                            
                finalValue = valueToSeparate.Split(Convert.ToChar(chars))[index];
            }

            return finalValue;
        }


    }
}
