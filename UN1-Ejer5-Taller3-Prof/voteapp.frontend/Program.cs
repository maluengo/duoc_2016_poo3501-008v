using System;
using System.Linq;
using voteapp.backend.business.Matrix;
using voteapp.backend.business.Tools;
using voteapp.backend.business.Votes;
using voteapp.backend.entities.Enums;

namespace voteapp.frontend
{
    class Program
    {
        private static string columnDistriteSize = string.Empty;   //Columnas
        private static string candidateRowsSize = string.Empty; //Filas
        private static int[,] Matrix = default(int[,]);

        static void Main(string[] args)
        {
            Console.WriteLine("***Simulador de votaciones para Alcaldes***\n");

            ExecuteMenu();

        }

        static void OptionGenrateRandomVotes()
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
                Matrix =  new RandomVotes().GenerateRandomIntVotes($"{candidateRowsSize.Trim()},{columnDistriteSize.Trim()}");

                if (!Matrix.Length.Equals(0))
                {
                    Console.WriteLine(menuHelper.PrintSuccessToUser($"Votos aleatorios generados exitosamente para {candidateRowsSize} candidatos en {columnDistriteSize} distritos."));
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
                    ? menuHelper.PrintErrorsToUser("El valor ingresado no puede ser vacío. Se espera un número. ")
                    : menuHelper.PrintSuccessToUser($"Se han establecido {columnDistriteSize} distritos"));
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
                    var matrixPrinter = new MatrixMaker();
                    Console.WriteLine("Resultado de las elecciones:");
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
                    ? menuHelper.PrintErrorsToUser("El valor ingresado no puede ser vacío. Se espera un número. ")
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
                            $"Antes de obtener el ganador, debe de generar los votos con la opcion '3' del menú."));
                }
                else
                {
                    Console.WriteLine($"El ganador de la votación fue quien obtuvo {new MatrixMaker().GetMaxVoteFromArray(Matrix)} votos");
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
                            $"Antes de obtener el segundo lugar, debe de generar los votos con la opcion '3' del menú."));
                }
                else
                {
                    var matrixHelper = new MatrixMaker();
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

        /// <summary>
        /// Permite ejecutar el menú, con las opciones requeridas. 
        /// </summary>
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
                    Console.WriteLine(menuHelper.PrintErrorsToUser("El valor debe ser número."));
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
                            Console.WriteLine("Adios... ;)");
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
