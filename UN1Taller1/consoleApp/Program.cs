using System;
using System.Globalization;
using Backend.Configuration;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generamos la instancia, el objeto de la clase AppConfigReader que esta en
            //la capa de Backend (class library).
            AppConfigReader configReader = new AppConfigReader();

            //Busca, con el método que se generó en la clase AppConfigReader, la etiqueta value
            //en base al key 'mi nombre'
            //  <add key="minombre" value="alex"/>
            var yourName = configReader.GetValueByKeyFromConfig("minombre");

            //ATR: Acá, establecemos el mensaje de bienvenida.  Este mensaje se hace con string.format y se le añade el nombre que se 
            //extra desde el archivo de configuracion.  La logica de extracción desde el archivo App.Config se encuentra en la capa Backend. 
            var welcomeMessage = string.Format("Bienvenido.  Segun el archivo de configuracion, su nombre es: {0} \n",
                yourName);

            //ATR: Acá guardamos el largo de la cadena de caracteres que se extrajo desde el archivo de configuracion, usando el property Lenght de la clase string. 
            //Acá, se obtiene el largo del nombre, usando el método 'GetSizeOfString' generdo en la clase
            //AppConfigReader
            int nameSize = configReader.GetSizeOfString(yourName);

            //ATR: El valor entero que guarda el largo del string, lo pasamos a String para poder desplegarlo como mensaje. 
            var sizeMessage = string.Format("El largo de su nombre es: {0}",
                nameSize.ToString(CultureInfo.CurrentCulture));

            

            //Se escribe por pantalla los resultados.
            Console.WriteLine(welcomeMessage);
            Console.WriteLine(sizeMessage);

            //Se espera la presión de una tecla para poder continuar (para evitar que el programa se abra y cierre sin
            //poder percibir lo desarrollado).
            Console.ReadKey();
        }
    }
}
