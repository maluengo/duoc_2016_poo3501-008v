using System;
using voteapp.backend.business.Tools;
using voteapp.backend.entities.Enums;

namespace voteapp.frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Simulador de votaciones para Alcaldes***\n");

            ExecuteMenu();

        }

        /// <summary>
        /// Permite ejecutar el menú, con las opciones requeridas. 
        /// </summary>
        private static void ExecuteMenu()
        {
            var isExit                   = false;
            Validations validationHelper = new Validations();
            MenuHelper menuHelper = new MenuHelper();

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

                    switch (menuHelper.MakeEnumByString(auxOptionFromConsole))
                    {
                        case MenuStruct.MenuOptionsEnum.IngresarCantidadDistritos:
                            Console.WriteLine(menuHelper.PrintInputToUser("Ingrese Cantidad de Distritos a Generar (Columnas): "));

                            break;
                        case MenuStruct.MenuOptionsEnum.IngresarCandidatos:
                            Console.WriteLine(menuHelper.PrintInputToUser("Ingrese Cantidad de Candidatos (Filas): "));
                            break;
                        case MenuStruct.MenuOptionsEnum.GenerarVotosAleatorios:
                            
                            break;
                        case MenuStruct.MenuOptionsEnum.GanadorPrimerLugarVotaciones:
                            break;
                        case MenuStruct.MenuOptionsEnum.SegundoLugarVotaciones:
                            break;
                        case MenuStruct.MenuOptionsEnum.ImprimirVotacionGeneral:
                            break;
                        case MenuStruct.MenuOptionsEnum.Salir:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            } while (!isExit);
        }
    }
}
