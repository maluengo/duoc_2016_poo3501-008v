using System;
using System.Linq;
using voteapp.backend.business.Matrix;
using voteapp.backend.business.Tools;
using voteapp.backend.business.Votes;
using voteapp.backend.entities.Enums;
using frontApp.UXFunctionality;
using backend.Entities.DTO;
using backend.Domain.UserManager;

namespace voteapp.frontend
{
    class Program
    {
        private static string columnDistriteSize = string.Empty;  
        private static string candidateRowsSize = string.Empty; 
        private static int[,] Matrix = default(int[,]);

        static void Main(string[] args)
        {
            
            Console.WriteLine("***Simulador de votaciones para Alcaldes***\n");
            CheckCredentials();
            //ExecuteMenu();
        }
        static void CheckCredentials()
        {
            Console.WriteLine("Ingresa las credenciales para validar acceso: (user:fran pass:123)\n");
            Console.WriteLine("USUARIO: (fran)");
            var userEnterInConsole = string.Empty;
            var passEnterInConsole = string.Empty;


            userEnterInConsole = Console.ReadLine();
            Console.WriteLine("Presiona [ENTER] para continuar \n");


            if (Console.ReadKey().Key != ConsoleKey.X)
            {
                Console.WriteLine("CONTRASEÑA: (123)");

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

                        Console.WriteLine($"Bienvenido usuario [{userEnterInConsole}] ");
                        ExecuteMenu();

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
        static void OptionGenrateRandomVotes()
        {
            MenuHelper menuHelper = new MenuHelper();
            if (string.IsNullOrEmpty(columnDistriteSize) || string.IsNullOrEmpty(candidateRowsSize))
            {
                Console.WriteLine(
                    menuHelper.PrintErrorsToUser(
                        "Primero debe seleccionar las opciones 1 y 2 "));
            }
            else
            {
                Matrix =  new RandomVotes().GenerateRandomIntVotes($"{candidateRowsSize.Trim()},{columnDistriteSize.Trim()}");

                if (!Matrix.Length.Equals(0))
                {
                    Console.WriteLine(menuHelper.PrintSuccessToUser($"se generaron votos para {candidateRowsSize} candidatos con {columnDistriteSize} distritos."));
                }

            }
            
        }

        static void EnterHowManyDistrites()
        {
            columnDistriteSize    = string.Empty;
            columnDistriteSize    = Console.ReadLine();
            MenuHelper menuHelper = new MenuHelper();
            Validations validationHelper = new Validations();

            Console.WriteLine(
                !validationHelper.IsNumeric(columnDistriteSize)
                    ? menuHelper.PrintErrorsToUser("no ingreso nada, intente nuevamente ")
                    : menuHelper.PrintSuccessToUser($"seran {columnDistriteSize} distritos"));
        }

        static void PrintVotes()
        {
            MenuHelper menuHelper = new MenuHelper();
            if (string.IsNullOrEmpty(columnDistriteSize) || string.IsNullOrEmpty(candidateRowsSize))
            {
                Console.WriteLine(
                    menuHelper.PrintErrorsToUser(
                        "Debe de ingresar candidatos y distritos para generar los votos aleatoriamente. Seleccione opción 1 y 2. "));
            }
            else
            {

                if (Matrix.Length.Equals(0))
                {
                    Console.WriteLine(
                        menuHelper.PrintErrorsToUser(
                            $"No se han generado los votos requeridos para {candidateRowsSize} candidatos en {columnDistriteSize} distritos."));
                }
                else
                {
                    var matrixPrinter = new Matriz();
                    Console.WriteLine("Resultado de las elecciones: ");
                    matrixPrinter.MakeStringMatrixByParameter(Matrix); 
                }

            }

        }

        static void EnterHowManyCandidates()
        {
            candidateRowsSize     = string.Empty;
            candidateRowsSize     = Console.ReadLine();
            MenuHelper menuHelper = new MenuHelper();
            Validations validationHelper = new Validations();

            Console.WriteLine(
                !validationHelper.IsNumeric(columnDistriteSize)
                    ? menuHelper.PrintErrorsToUser("no puede dejar en blanco ")
                    : menuHelper.PrintSuccessToUser($"Se han establecido {candidateRowsSize} candidatos para ésta elección."));
        }

        static void GetMaxVotesNumber()
        {
            if (!object.ReferenceEquals(Matrix, null))
            {
                if (Matrix.Length.Equals(0))
                {
                    Console.WriteLine(
                        new MenuHelper().PrintErrorsToUser(
                            $"no hay ganadores sin votos, seleccione la opcion '3' del menú."));
                }
                else
                {
                    Console.WriteLine($"El ganador obtuvo {new Matriz().GetMaxVoteFromArray(Matrix)} votos");
                }
            }
            else
            {
                Console.WriteLine(
                        new MenuHelper().PrintErrorsToUser(
                            $"No se han generado los votos requeridos para {candidateRowsSize} candidatos en {columnDistriteSize} distritos."));

            }

        }

        static void GetSecondVotesNumber()
        {
            if (!object.ReferenceEquals(Matrix, null))
            {
                if (Matrix.Length.Equals(0))
                {
                    Console.WriteLine(
                        new MenuHelper().PrintErrorsToUser(
                            $"no hay segundo lugar sin votos, seleccione la opcion '3' del menú."));
                }
                else
                {
                    var matrixHelper = new Matriz();
                    Console.WriteLine(
                        $"El segundo lugar fue quien obtuvo {matrixHelper.GetSecondPlaceInVotes(Matrix)} votos, el primero fue {matrixHelper.GetMaxVoteFromArray(Matrix)}");
                }

            }
            else
            {
                Console.WriteLine(
                        new MenuHelper().PrintErrorsToUser(
                            $"No se han generado los votos requeridos para {candidateRowsSize} candidatos en {columnDistriteSize} distritos."));

            }
            

        }
        
        private static void ExecuteMenu()
        {
            var isExit                   = false;
            Validations validationHelper = new Validations();
            MenuHelper menuHelper        = new MenuHelper();



            do
            {
                Console.WriteLine(menuHelper.PrintMenuOptionsInScreen());
                var auxOptionFromConsole = Console.ReadLine();
                Console.ReadKey();

                if (!validationHelper.IsNumeric(auxOptionFromConsole))
                {
                    Console.WriteLine(menuHelper.PrintErrorsToUser("Solo se pueden ingresar numeros :O!"));
                }
                else
                {

                    switch(menuHelper.MakeEnumByString(auxOptionFromConsole))
                    {
                        case MenuStruct.MenuOptionsEnum.IngresarCantidadDistritos:
                            Console.WriteLine(menuHelper.PrintInputToUser("Ingrese Cantidad de Distritos a Generar (Columnas): "));
                            EnterHowManyDistrites();
                            Console.ReadKey();

                            break;

                        case MenuStruct.MenuOptionsEnum.IngresarCandidatos:
                            Console.WriteLine(menuHelper.PrintInputToUser("Ingrese Cantidad de Candidatos (Filas): "));
                            EnterHowManyCandidates();
                            Console.ReadKey();
                            break;

                        case MenuStruct.MenuOptionsEnum.GenerarVotosAleatorios:
                            OptionGenrateRandomVotes();
                            Console.ReadKey();
                            break;

                        case MenuStruct.MenuOptionsEnum.GanadorPrimerLugarVotaciones:
                            GetMaxVotesNumber();
                            Console.ReadKey();
                            break;

                        case MenuStruct.MenuOptionsEnum.SegundoLugarVotaciones:
                            GetSecondVotesNumber();
                            Console.ReadKey();
                            break;

                        case MenuStruct.MenuOptionsEnum.ImprimirVotacionGeneral:
                            PrintVotes();
                            Console.ReadKey();
                            break;

                        case MenuStruct.MenuOptionsEnum.Salir:
                            isExit = true;
                            Console.WriteLine("Gracias por participar de las elecciones");
                            Console.ReadKey();
                            break;

                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            } while (!isExit);
        }
    }
}
