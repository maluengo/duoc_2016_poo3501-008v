using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2._4.App.Back.Credentials;
using _2._4.App.Back.Entities;

namespace _2._4.App.Front
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al ejercicio 2.4 Validar credenciales. \n");
            ExecuteValidation();
        }

         static void ExecuteValidation()
        {
            var credentialsHelper = default(CredentialsValidations);  
            
            var isValueOk = false;

            do
            {
                Console.WriteLine($"\nIngrese el Usuario:");
                var userNameInConsole = Console.ReadLine();
                Console.ReadKey();

                

                if (string.IsNullOrEmpty(userNameInConsole))
                {
                    Console.WriteLine("\nDebe de ingresar un valor distinto de VACIO o NULL para el USUARIO");
                }
                else
                {
                    Console.WriteLine($"\nIngrese el Password:");
                    var passInConsole = Console.ReadLine();
                    Console.ReadKey();

                    if (string.IsNullOrEmpty(passInConsole))
                    {
                        Console.WriteLine("\nDebe de ingresar un valor distinto de VACIO o NULL para el PASSWORD");

                    }
                    else
                    {    
                        credentialsHelper = new CredentialsValidations();
                        var auxuserCredentials = new CredentialsDto()
                        {
                            userName = userNameInConsole,
                            passWord = passInConsole
                        };

                        if(credentialsHelper.isCredentialsValid(auxuserCredentials) )
                        {
                            isValueOk = true;
                            Console.WriteLine($"\nLogin Exitoso.  Bienvenido usuario {auxuserCredentials.userName}");
                        }
                        else
                        {
                            Console.WriteLine($"\nLogin Fallido.  Inténtelo nuevamente.");

                        }

                    }
                    
                }

                Console.ReadKey();

            } while (!isValueOk);
        }
    }
}
