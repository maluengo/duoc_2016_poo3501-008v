using System;
using System.Linq;
using Backend.AppConfigManager;
using Backend.Domain.Students;
using Backend.Messages;
using Backend.Tools;

namespace frontend
{
    class Program
    {

        /// <summary>
        /// Muestra el menu por pantalla, además permite validar la opción seleccionada. 
        /// </summary>
        /// <returns></returns>
        static int ShowMenu()
        {
            var flagIsExit     = false;
            var valueChecker   = new ValueChecker();
            var messageHelper  = new MessageManager();
            var selectedOption = default(int);

            do
            {
                Console.WriteLine(messageHelper.ShowMenu());
                var auxSelectedOption = Console.ReadLine();

                //Comprobamos si el usuario ha ingresado una opción valida en el menú.  Si ha ingresado algún caracter
                //no convertible a número, se le enviará un mensaje. 
                if (!valueChecker.CheckIfValueIsNumeric(auxSelectedOption) || (string.IsNullOrEmpty(auxSelectedOption)))
                {
                    Console.WriteLine($"[ERROR] - Opción inválida ({auxSelectedOption}), inténtelo nuevamente");
                }
                else
                {
                    //Si el usuario selecciona 3, eligió salir. 
                    flagIsExit     = true;
                    selectedOption = int.Parse(auxSelectedOption); 
                }  

            } while (!flagIsExit);


            return selectedOption;

        }

        /// <summary>
        /// Muestra los mensajes de bienvenida y chequear si el usuario está o no autorizado para ejecutar el programa. 
        /// </summary>
        static void CheckUsersAndShowMessages()
        {
            var configHelper = new AppConfigReader();
            var messageHelper = new MessageManager();
            var auxUserEnterInScree = string.Empty;

            //Se le pide al usuario que ingrese el perfil, para evaluar si está o no autorizado. 
            var auxFlagIsEmpty = true; //Nos permitirá evaluar si el usuario ingresó o no un perfil.  Sino, insistirá hasta que lo haga.
            var auxFlagIsUserOk = false; //Nos permite determinar s el usuario ingresado corresponde o es inválido. 


            do
            {
                Console.WriteLine("Ingrese el perfil del usuario autorizado para ejecutar este programa, luego presione una tecla: \n");
                auxUserEnterInScree = Console.ReadLine();
                Console.ReadKey();

                if (string.IsNullOrEmpty(auxUserEnterInScree))
                {
                    Console.WriteLine("Debe de ingresar un perfil valido... inténtelo nuevamente");
                }
                else
                {
                    auxFlagIsEmpty = false;
                }

            } while (auxFlagIsEmpty);

            do
            {
                if (string.IsNullOrEmpty(auxUserEnterInScree))
                {
                    Console.WriteLine("Ingrese el perfil del usuario autorizado para ejecutar este programa, luego presione una tecla: \n");
                    auxUserEnterInScree = Console.ReadLine();
                    Console.ReadKey();
                }

                //Comprueba si el usuario ingresado, existe o no como "Value" en el App.Config. 
                if (!configHelper.CheckIfValueExistInConfig("useradministrador", auxUserEnterInScree))
                {
                    Console.WriteLine(messageHelper.ShowNotAuthorizedMessage(auxUserEnterInScree));
                    auxUserEnterInScree = string.Empty;
                }
                else
                {
                    auxFlagIsUserOk = true;
                    Console.WriteLine(messageHelper.ShowWelComeMessage());
                }

            } while (!auxFlagIsUserOk);

        }

        /// <summary>
        /// Lista, por pantalla, todos los alumnos en estado 'pre seleccionados'
        /// </summary>
        static void ListAllStudents()
        {
            var studentsHelper = new StudentsReader();
            var allStudents = studentsHelper.GetAllStudents();

            if (allStudents.Any())
            {
                Console.WriteLine("[RESULT] - Nómina de pre-seleccionados\n");
                Console.WriteLine("*********************************************\n");
                foreach (var item in allStudents)
                {
                    Console.Write($"Nombre Alumno: [{item.Name}]    | Ingreso Familiar: [{item.CashByStudent}]\n");
                }

            }

        }

        static void ListaStudentsByBaseLine()
        {
            Console.WriteLine("Ingrese la linea base para generar lista de alumnos SELECICONADOS: ");
            var baseLine = Console.ReadLine();
            var valueChecker = new ValueChecker();
            var studentHelper = new StudentsReader();

            if (!string.IsNullOrWhiteSpace(baseLine) && (valueChecker.CheckIfValueIsNumeric(baseLine)))
            {
                Console.WriteLine("[RESULT] - Nómina de seleccionados\n");
                Console.WriteLine($"[RESULT] - BaseLine ingresado: {baseLine}\n");
                Console.WriteLine("*********************************************\n");

                foreach (var item in studentHelper.GetAllStudentsByBaseLine(int.Parse(baseLine)))
                {
                    Console.Write($"Nombre Alumno: [{item.Name}] | Ingreso Familiar: [{item.CashByStudent}] | SELECCIONADO\n");
                }  
            }

        }

        /// <summary>
        /// Método Main, entry point para la aplicación (punto de entrada). 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            //Verifica usuario autorizado.
            CheckUsersAndShowMessages();

            //Muestra el menu con opcines disponibles, solo si el usuario ha sido previamente autenticado como 'usuario autorizado'
            var opcion = ShowMenu();

            if (opcion.Equals(3))
            {
                Console.WriteLine("[AVISO] - Adios. Presione cualquier tecla para salir.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                //Se ejecutará alguna de las opciones seleccionadas por el usuario. 
                Console.WriteLine($"[AVISO] - Ha seleccionado la opción: {opcion} \n");

                switch (opcion)
                {
                    case 1:
                        //Listar alumnos
                        ListAllStudents();
                        
                        break;

                    case 2:
                        //Listar alumnos pre-seleccionados según línea base ingresada por pantalla. 
                        Console.WriteLine("Alumnos pre-seleccionados \n");
                        ListAllStudents();
                        ListaStudentsByBaseLine();

                        break;
                         

                }

                Console.ReadKey();

            }
            

        }
    }
}
