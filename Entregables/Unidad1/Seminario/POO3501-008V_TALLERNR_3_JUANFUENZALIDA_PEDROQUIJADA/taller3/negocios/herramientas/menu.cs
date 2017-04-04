using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace negocios.herramientas
{
    class menu
    {
        /// <summary>
        /// Encapsula la lógica del despliegue del menú en pantalla. 
        /// </summary>
        /// <returns></returns>
        public string PrintMenuOptionsInScreen()
        {

            var objBuilder = new StringBuilder();
            objBuilder.Append("*******MENU*******\n");
            objBuilder.Append("--> [1] Ingresar Cantidad de Distritos\n");
            objBuilder.Append("--> [2] Ingresar Cantidad de Candidatos\n");
            objBuilder.Append("--> [3] Generar votos aleatorios\n");
            objBuilder.Append("--> [4] Obtener Ganador de elecciones\n");
            objBuilder.Append("--> [5] Obtener Segundo Lugar\n");
            objBuilder.Append("--> [6] Imprimir Reporte Votaciones Finales\n");
            objBuilder.Append("--> [7] Salir\n");
            objBuilder.Append("*******MENU*******\n\n");
            objBuilder.Append("Ingrese la Opción (presione una tecla): \n");


            return objBuilder.ToString();
        }

        /// <summary>
        /// Despliega y construye el formato del mensaje de error, por pantalla. 
        /// </summary>
        /// <param name="customMessage"></param>
        /// <returns></returns>
        public string PrintErrorsToUser(string customMessage)
        {
            var finalMessage = string.Empty;

            if (!string.IsNullOrEmpty(customMessage))

            {
                finalMessage = $"[ERROR] - {customMessage}\n";

            }

            return finalMessage;
        }

        /// <summary>
        /// Despliega y construye el formato del mensaje de error, por pantalla. 
        /// </summary>
        /// <param name="customMessage"></param>
        /// <returns></returns>
        public string PrintSuccessToUser(string customMessage)
        {
            var finalMessage = string.Empty;

            if (!string.IsNullOrEmpty(customMessage))

            {
                finalMessage = $"[SUCCESS] - {customMessage}\n";

            }

            return finalMessage;
        }

        /// <summary>
        /// Despliega y construye el formato del mensaje de error, por pantalla. 
        /// </summary>
        /// <param name="customMessage"></param>
        /// <returns></returns>
        public string PrintInputToUser(string customMessage)
        {
            var finalMessage = string.Empty;

            if (!string.IsNullOrEmpty(customMessage))

            {
                finalMessage = $"[INPUT] - {customMessage}\n";

            }

            return finalMessage;
        }

        /// <summary>
        /// Despliega y construye el formato del mensaje de error, por pantalla. 
        /// </summary>
        /// <param name="customMessage"></param>
        /// <returns></returns>
        public string PrintMessageInfoToUser(string customMessage)
        {
            var finalMessage = string.Empty;

            if (!string.IsNullOrEmpty(customMessage))

            {
                finalMessage = $"[INFO] - {customMessage}\n";

            }

            return finalMessage;
        }

        /// <summary>
        /// Permite, a partir de un string, castear a un Enum. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public MenuStruct.OpcionesMenu MakeEnumByString(string value)
        {
            var enumToCast = default(MenuStruct.OpcionesMenu);

            if (!string.IsNullOrEmpty(value))
            {
                if (new Validations().IsNumeric(value))
                {
                    var auxIntValue = int.Parse(value);

                    enumToCast = (MenuStruct.MenuOptionsEnum)auxIntValue;
                }

            }

            return enumToCast;
        }
    }
}
