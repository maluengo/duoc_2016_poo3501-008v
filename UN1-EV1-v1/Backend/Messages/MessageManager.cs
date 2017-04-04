using System.Text;
using Backend.AppConfigManager;

namespace Backend.Messages
{
    /// <summary>
    /// ATR: Clase que encapsula toda la lógica de mostrar mensajes por pantalla. 
    /// </summary>
    public class MessageManager
    {

        /// <summary>
        /// Muestra el mensaje de bienvenida, sólo si el usuario ingresado por pantalla coincide con el registrado en 
        /// el application config. 
        /// </summary>
        /// <returns></returns>
        public string ShowWelComeMessage()
        {
            var messageToShow = string.Empty;
            var appConfigHelper = new AppConfigReader();
            var auxUserInConfig = appConfigHelper.GetValueFromKeyInAppConfig("useradministrador");

            if (!string.IsNullOrEmpty(auxUserInConfig))
            {
                messageToShow = $"Bienvenido usuario {auxUserInConfig}\n";

            }   

            return messageToShow;
        }

        /// <summary>
        /// Encapsula la logica de mostrar el mensaje de "usuario no autorizado" por pantalla. 
        /// </summary>
        /// <param name="userEntered"></param>
        /// <returns></returns>
        public string ShowNotAuthorizedMessage(string userEntered)
        {
            var messageToShow = default(string);

            if (!string.IsNullOrEmpty(userEntered))
            {
                messageToShow = $"Usuario {userEntered} no valido.  intentelo nuevamente...\n";
            }

            return messageToShow;

        }

        /// <summary>
        /// Encapsula la lógica de desplegar el menu de opciones por pantalla. 
        /// </summary>
        /// <returns></returns>
        public string ShowMenu()
        {
            var menu = string.Empty;
            var objBuilder = new StringBuilder();
            objBuilder.Append("\n********Menu de Opciones********");
            objBuilder.AppendLine();
            objBuilder.Append("*Opcion1: Listar alumnos preseleccionados.\n");
            objBuilder.Append("*Opcion2: Generar nómina final de alumnos.\n");
            objBuilder.Append("*Opcion3: Salir.\n");
            objBuilder.Append("**********************************\n");
            objBuilder.AppendLine();
            objBuilder.Append("*OPCION: \n");
            objBuilder.AppendLine();

            menu = objBuilder.ToString();

            return menu;
        }

        
        


    }
}
