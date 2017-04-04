using System;
using System.Net;
using backend.Domain.UserManager;
using backend.Entities.DTO;
using frontApp.UXFunctionality;

namespace frontApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPreviousSettingsAndMessages();

        }

        static void CheckCredentials()
        {
            Console.WriteLine("Ingresa las credenciales para validar acceso: \n");
            Console.WriteLine("[USUARIO:]");
            var userEnterInConsole = string.Empty;
            var passEnterInConsole = string.Empty;


            userEnterInConsole = Console.ReadLine();
            Console.WriteLine("Presiona [ENTER] para continuar \n");


            if (Console.ReadKey().Key != ConsoleKey.X)
            {
                Console.WriteLine("[PASSWORD:]");

                passEnterInConsole = Console.ReadLine();
                Console.WriteLine("Presiona [ENTER] para validar credenciales \n"); 

                if (Console.ReadKey().Key != ConsoleKey.X)
                {
                    var objChecker = new CredentialsChecker();

                    if (objChecker.CheckIfCredentialsAreOk(new UserInformationDto()
                    {
                        passWord = passEnterInConsole,
                        userName = userEnterInConsole
                    }))
                    {
                       
                        Console.WriteLine($"Bienvenido usuario [{userEnterInConsole}] \n");
                        Console.WriteLine("Presiones E para salir del programa:");

                        if (UXManager.CheckIfKeyisAnything("E", Console.ReadKey().Key.ToString()))
                        {
                            Environment.Exit(0);
                        }

                    }
                    else
                    {
                        Console.WriteLine($"Credenciales ingresadas incorrectas!! Sólo se admite un intento.");
                        Console.WriteLine("Presiones E para salir del programa:");

                        if (UXManager.CheckIfKeyisAnything("E", Console.ReadKey().Key.ToString()))
                        {
                            Environment.Exit(0);
                        }
                    }

                }
            }

        }

        static void CheckPreviousSettingsAndMessages()
        {
            Console.WriteLine(UXManager.GetWelComeMessage());
            Console.WriteLine(UXManager.DisplayInstructionsInConsoleScreen());

            var keyPress = Console.ReadKey().Key.ToString();

            if (UXManager.CheckIfEnterYes(keyPress))
            {
                Console.WriteLine("\nHa decidido continuar =) \n");
                CheckCredentials();
            }
        }
    }
}
