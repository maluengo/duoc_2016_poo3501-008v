using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voteapp.backend.entities.Enums;

namespace voteapp.backend.business.Tools
{
    public class MenuHelper
    {
        public string PrintMenuOptionsInScreen()
        {    

            var objBuilder = new StringBuilder();
            objBuilder.Append("\n\n--------Seleccion--------\n");
            objBuilder.Append("1) Ingresar los Distritos\n");
            objBuilder.Append(" 2) Ingresar los Candidatos\n");
            objBuilder.Append("  3) Generar votos\n");
            objBuilder.Append("   4) Ganador de elecciones\n");
            objBuilder.Append("    5) Segundo Lugar\n");
            objBuilder.Append("     6) Imprimir Reporte Votaciones Finales\n");
            objBuilder.Append("      7) Salir\n\n");
            objBuilder.Append("........elija una opcion y presione enter para continuar........");


            return objBuilder.ToString();
        }
        
        public string PrintErrorsToUser(string customMessage)
        {
            var finalMessage = string.Empty;

            if (!string.IsNullOrEmpty(customMessage))

            {
                finalMessage = $"[ERROR] - {customMessage}\n";

            }

            return finalMessage;
        }
        
        public string PrintSuccessToUser(string customMessage)
        {
            var finalMessage = string.Empty;

            if (!string.IsNullOrEmpty(customMessage))

            {
                finalMessage = $"[SUCCESS] - {customMessage}\n";

            }

            return finalMessage;
        }
        
        public string PrintInputToUser(string customMessage)
        {
            var finalMessage = string.Empty;

            if (!string.IsNullOrEmpty(customMessage))

            {
                finalMessage = $"[INPUT] - {customMessage}\n";

            }

            return finalMessage;
        }
        
        public string PrintMessageInfoToUser(string customMessage)
        {
            var finalMessage = string.Empty;

            if (!string.IsNullOrEmpty(customMessage))

            {
                finalMessage = $"[INFO] - {customMessage}\n";

            }

            return finalMessage;
        }
        
        public MenuStruct.MenuOptionsEnum MakeEnumByString(string value)
        {
            var enumToCast = default(MenuStruct.MenuOptionsEnum);

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
