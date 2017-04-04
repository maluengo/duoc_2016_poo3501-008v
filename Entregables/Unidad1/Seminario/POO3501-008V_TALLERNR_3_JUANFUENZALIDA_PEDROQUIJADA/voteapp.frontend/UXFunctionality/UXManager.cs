using System;
using System.Text;
using backend.Functionality.AppConfigReader;

namespace frontApp.UXFunctionality
{
    public static class UXManager
    {
        public static string GetWelComeMessage()
        {
            return
                $"Bienvenido usuario" +
                $" {new ConfigurationManagerFacade().GetAnyValueFromConfigByKey("CurrentUser")} " +
                $"- \n**POO3501-008V**\n";
        }

        public static string DisplayInstructionsInConsoleScreen()
        {
            var message = new StringBuilder();
            message.Append("Debe Ingresar usuario y password para poder continuar");
            message.AppendLine();
            message.Append("las credenciales serán validadas contra un archivo de configuracion");
            message.Append("¿Desea continuar? (Y/N)");

            return message.ToString();
        }

        public static bool CheckIfEnterYes(string keyInString)
        {
            var isYes = default(bool);

            if (!string.IsNullOrEmpty(keyInString))
            {
                isYes = string.Equals(keyInString.ToUpper(), "Y", StringComparison.InvariantCultureIgnoreCase);
            }   

            return isYes;

        }

        public static bool CheckIfEnterNo(string keyInString)
        {
            var isYes = default(bool);

            if (!string.IsNullOrEmpty(keyInString))
            {
                isYes = string.Equals(keyInString.ToUpper(), "N", StringComparison.InvariantCultureIgnoreCase);
            }

            return isYes;

        }

        public static bool CheckIfKeyisAnything(string keyInString, string keyToValidate)
        {
            var isYes = default(bool);

            if (!string.IsNullOrEmpty(keyInString))
            {
                isYes = string.Equals(keyInString.ToUpper(), keyToValidate, StringComparison.InvariantCultureIgnoreCase);
            }

            return isYes;

        }

        public static string DisplayGoodByMessage()
        {
            return "Gracias, ¡Adios!";
        }

    }
}
