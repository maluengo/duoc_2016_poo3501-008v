using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Validators;
using backend.Operations;

namespace frontend
{
    class Program
    {
        static void Main(string[] args)
        {
            Validator validador = new Validator();
            CountVotes count = new CountVotes();
            ManejoString manejoString = new ManejoString();
            Operaciones op = new Operaciones();

            //validador para el ciclo del menu
            bool valueAxu = default(bool);
            //validador para validar las reglas de negocio en las opciones del menu
            bool validadorCiclo = default(bool);
            //
           // bool validOption = default(bool);
           //variable que sirve para almacenar el dato de distritos
            int valid = default(int);
            //variable que sirve para almacenar el dato de candidatos
            int valid2 = default(int);
            //variable que almacena la opcion a seleccionar en el menu
            string options = default(string);
            //variable que almacenara el dato de la opcion convertida a Int
            int option = default(int);
            //Variable apra validar el ciclo de opcion del menu
            bool valoption = default(bool);
            //variable que sirve para almacenar el mayor 
            int mayor = default(int);
            //variable que sirve para alacenar el menor
            int menor = default(int);
            //variable que sirve para almacenar el segundo mayor
            int segundoMayor = default(int);
            //arreglo que contiene el total de votos de cada candidato
            int[] totalVotosXCandidato = null;
            //arreglo que guarda la matriz de votos de candidatos por distrito
            int[,] distritos = null;
            //variable que guarda el indice del candidato con mayor puntaje
            int candidatoMayor = default(int);

            do {
                Console.Clear();
                Console.WriteLine("opcion 1: Ingrese la cantidad de Distritos (minimo 5 y maximo 7)");
                Console.WriteLine("Opcion 2: Ingrese cantidad de Candidatos (minimo 3 y maximo 5)");
                Console.WriteLine("Opcion 3: Obtener el primer candidato con mas votado");
                Console.WriteLine("Opcion 4: Obteber el segundo candidato con mas votos");
                Console.WriteLine("Opcion 5: Mostrar todos los votos");
                Console.WriteLine("Opcion 6: Salir \n");
                
                do
                {
                    Console.WriteLine("Ingrese su opcion");
                    options = Console.ReadLine();
                    valoption = validador.validCandidates(options);

                    if (!valoption)
                    {
                        Console.Clear();
                        Console.WriteLine("debe ingresar una opcion numerica");
                        Console.ReadKey();
                    }
                    else
                    {
                        option = Convert.ToInt32(options);
                        if(option>0 && option<7)
                            valoption = true;
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("debe ingresar una opcion valida (del 1 al 6)");
                            Console.ReadKey();
                        }
                    }
                } while (!valoption);
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Ingrese la cantidad de distritos\n");
                            string distritCant = Console.ReadLine();
                            var valDist = validador.validDistrit(distritCant);
                            if (valDist)
                            {
                               /*
                               enviamos el string al metodo RecivirDistritos para que sea convertido a un Int y 
                               sea almacenado para luego ser utilizado en la matriz
                               */

                               valid = count.recivirDistritos(distritCant);
                                if (valid > 4 && valid < 8)
                                    validadorCiclo = true;
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("debe ingresar un valor valido (del 5 al 7)");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese un valor numerico valido\n");
                                Console.ReadKey();
                                validadorCiclo = false;
                            }
                            
                        } while (!validadorCiclo);
                        if (valid2 > 0)
                        {
                            distritos = count.countVotos(valid2, valid);
                            for (int i = 0; i < valid2; i++)
                                for (int j = 0; j < valid; j++)
                                    totalVotosXCandidato[i] += distritos[i, j];
                        }
                        Console.Clear();
                        Console.WriteLine("datos ingresados, favor precione una tecla para continuar\n");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        do {
                            Console.WriteLine("Ingrese la cantidad de candidatos\n");
                            string candidatesCant = Console.ReadLine();
                            var valCand = validador.validDistrit(candidatesCant);
                            if (valCand)
                            {
                                /*
                               enviamos el string al metodo RecivirDistritos para que sea convertido a un Int y 
                               sea almacenado para luego ser utilizado en la matriz
                               */

                                valid2 = count.recivirCandidatos(candidatesCant);
                                if (valid2 > 2 && valid2 < 6)
                                {
                                    validadorCiclo = true;
                                    totalVotosXCandidato = new int[valid2];
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("debe ingresar un valor valido (del 3 al 5)");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Ingrese un valor numerico valido\n");
                                Console.ReadKey();
                                validadorCiclo = false;
                            }
                        } while (!validadorCiclo);

                        if (valid > 0)
                        {
                            distritos = count.countVotos(valid2, valid);
                            for (int i = 0; i < valid2; i++)
                                for (int j = 0; j < valid; j++)
                                    totalVotosXCandidato[i] += distritos[i, j];
                        }
                        Console.Clear();
                        Console.WriteLine("datos ingresador, favor precione una tecla para continuar\n");
                        Console.ReadKey();
                        break;

                    case 3:
                        if (valid > 0 && valid2 > 0)
                        {
                            candidatoMayor = op.getMayorDeArreglo(totalVotosXCandidato);
                            Console.Clear();
                            Console.WriteLine("El candidato " + (candidatoMayor+1) + " salio primero con " 
                                + totalVotosXCandidato[candidatoMayor] + " votos");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Primero debe ingresar cantidad de candidatos y distritos");
                            Console.ReadKey();
                        }
                        break;

                    case 4:
                        if (valid > 0 && valid2 > 0)
                        {
                            int candidatoSegundo = default(int);
                            candidatoSegundo = op.getSegundoDeArreglo(totalVotosXCandidato);
                            Console.Clear();
                            Console.WriteLine("El candidato " + (candidatoSegundo+1) 
                                + " salio segundo con " + totalVotosXCandidato[candidatoSegundo] + " votos");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Primero debe ingresar cantidad de candidatos y distritos");
                            Console.ReadKey();
                        }
                        break;

                    case 5:
                        if (valid == 0 || valid2 == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Primero debe ingresar cantidad de candidatos y distritos");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Clear();
                            string msj = string.Empty;
                            msj = manejoString.agregarEspacios(" ", 20, 0);
                            for (int j = 0; j < valid; j++)
                                msj += manejoString.agregarEspacios("Dist. " + (j + 1), 10, 3);
                            msj += "   Total";
                            Console.WriteLine(msj);
                            for (int i = 0; i < valid2; i++)
                            {
                                Console.WriteLine("-------------------------------------------------------------------------");
                                Console.Write(manejoString.agregarEspacios("Candidato " + (i + 1), 13, 0));
                                for (int j = 0; j < valid; j++)
                                {
                                    Console.Write(manejoString.agregarEspacios(string.Concat(distritos[i, j]), 13, 3));
                                }
                                Console.WriteLine("  " + totalVotosXCandidato[i]);
                                Console.WriteLine("-------------------------------------------------------------------------");
                            }
                            Console.ReadKey();
                        }
                        break;
                }
            } while (option != 6);
            Console.Clear();
            Console.WriteLine("hasta luego");
            Console.ReadKey();
        }
    }
}
