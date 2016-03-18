using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using blackend.AppConfigManager;

namespace frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            var configReader = new ConfigReader(); 

            //Obtener desde el config, especificamente, desde el backend. 
            string miNombreDesdeElConfig = configReader.ObtenerValorPorIdentificador("minombre");

            string largoDelNombre = configReader.ObtenerLargo(miNombreDesdeElConfig).ToString();

            //dar formato a mensaje con el metodo format de la clase string.
            string msjBievenida = string.Format("Bienvenido pelagato : {0}", miNombreDesdeElConfig);
            string msjDelLargo = string.Format("\nel largo de tu nombre es: {0}", largoDelNombre);
            //string algoconcatenado = "hola" + "pelagato";
            string algoconcatenado = string.Concat("tustring1", "tustring2");

            //Generando concatenacion con StringBuilder.
            //StringBuilder objBuilder = new StringBuilder();  //genero instancia. 
            //objBuilder.Append("tustring1");
            //objBuilder.Append("tustring2");
            //objBuilder.Append("tustring3");
            //objBuilder.Append("tustring4");
            //objBuilder.Append("tustring5");
            //objBuilder.ToString();


            //como inicializo.
            //string algo = string.Empty;
            //string algo3 = default(string);


            Console.WriteLine(msjBievenida);
            Console.WriteLine(msjDelLargo);

            Console.ReadKey();


        }
    }
}
