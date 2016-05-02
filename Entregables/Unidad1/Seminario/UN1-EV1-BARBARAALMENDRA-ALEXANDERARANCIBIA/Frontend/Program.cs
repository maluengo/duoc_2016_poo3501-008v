using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Config;

namespace Frontend
{
    class Program
    {
        static void Main(string[] args)
        {

            Configurador confi = new Configurador();
            string[] nombres = new string[10] { "Alex Arancibia  ", "Jian Soto       ", "Barbara Almendra", "Maria Bernal    ", "Rosa Garrido    ", "Pedro Soto      ", "Diego Flores    ", "Ana Pereira     ", "Alan Rojas      ", "Jose Toro       " };
            string[] ruts = new string[10] { "19522345-9", "12345678-9", "19098474-5", "16745678-2", "19397648-5", "18456879-6", "19659333-7", "17996448-8", "19063031-9", "18449566-k" };
            int[] edades = new int[10] {18, 22, 30, 20, 25, 40, 45, 20, 29, 32};
            int[] ingresos = new int[10] { 100, 150, 200, 250, 180, 110, 170, 230, 300, 320 };
            var opcion = "0";
            
            var user = confi.GetValueByKeyFromConfig("user");
            var pass = confi.GetValueByKeyFromConfig("pass");
            
            Console.WriteLine("Ingrese el Usuario autorizado para ejecutar este programa");
            var usuario = Console.ReadLine();
            Console.WriteLine("Ingrese Contraseña");
            var contraseña = Console.ReadLine();
            if (string.Equals(usuario, user, StringComparison.InvariantCulture) && string.Equals(contraseña, pass, StringComparison.InvariantCulture))
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("bienvenido usuario Administrador {0}", user);
                    Console.WriteLine("1) Listar Alumnos en estado pre-seleccionado");
                    Console.WriteLine("2) Generar nomina final de alumnos");
                    Console.WriteLine("3) Salir");

                    opcion = Console.ReadLine();
                    switch (opcion)
                    {
                        case "1":
                            Console.WriteLine("Nombre             Rut         Edad    Ingreso[miles]");
                            Console.WriteLine("-----------------------------------------------------");
                            for (int i = 0; i < 10; i++)
                            {
                                Console.WriteLine(nombres[i] + " " + ruts[i] + "     " + edades[i] + "     " + ingresos[i]);
                                
                            }
                            break;
                        case "2":
                            Console.WriteLine("Ingrese limite ingresos[miles]");
                            var ingresolimite = Console.ReadLine();                   
                            Console.WriteLine("Ingrese desde que edad");
                            var edadlimite = Console.ReadLine();
                            Console.WriteLine("-----------------------------------------------------");
                            Console.WriteLine("Alumnos en estado de seleccion");
                            Console.WriteLine("Nombre             Rut         Edad    Ingreso[miles]");
                            Console.WriteLine("-----------------------------------------------------");
                            for (int i = 0; i < 10; i++)
                            {
                                if (ingresos[i] <= int.Parse(ingresolimite) && edades[i] >= int.Parse(edadlimite))
                                {
                                    Console.WriteLine(nombres[i] + " " + ruts[i] + "     " + edades[i] + "     " + ingresos[i]);
                                }
                            }
                            break;
                        case "3":
                            Console.WriteLine("Saliendo");
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadLine();
                } while (opcion != "3") ;
                                
            }
            else {
                Console.WriteLine("Usuario {0} no autorizado ", usuario);
                Console.WriteLine("Contrasena utilizada: {0} ", contraseña);
            }
            Console.WriteLine("-----------------------");
            Console.WriteLine("Saliendo");
            Console.ReadKey();
        }
    }
}
