using System;

namespace DataManagert
{
    public class Menu
    {
        Validation validation = new Validation();
        GenerationData data = new GenerationData();
        public int distrito = default(int);
        public int candidato = default(int);
        public int option = default(int);
        public int maxVoteCandidate = default(int);
        public int topCandidate = default(int);
        //impresion del menu para interactuar con usuario
        public void OutMenu()
        {
            Console.WriteLine("   Menu de Simulador electoral      ");
            Console.WriteLine("-", 30);
            Console.WriteLine(" ");
            Console.WriteLine("Selecciones alguna de las siguentes opciones");
            Console.WriteLine(" ");
            Console.WriteLine("1) Ingrese cantidad de 'Distritos' y 'Candidatos'  ");
            Console.WriteLine("2) Generar cantidad de votos para Candidato x Distrito");
            Console.WriteLine("3) Calcula el Candidato con mayor cantidad de votos");
            Console.WriteLine("4) Calcula el segundo candidato con mayor cantidad de votos");
            Console.WriteLine("5) Imprime matriz de votos de Candidatos x Distrito");
            Console.WriteLine("6) Salir");
            string op = Console.ReadLine();
            if (validation.IsNumeric(op))
            {
                option = int.Parse(op);
            }
            else
            {
                option = default(int);
                Console.WriteLine("La opcion ingresada es incorrecta");
            }

        }
        //selección de opciones del menu
        public int OptionSelect(int op)
        {
            int aux = default(int);
            switch (op)
            {
                case 1:
                    IntoDataForElection();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    if (distrito != 0 && candidato != 0)
                    {
                        data.GetMatrizData(distrito, candidato);

                        string print = data.PrintMatriz(distrito, candidato);
                        Console.WriteLine(print);
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine("No se a ingresado los valores de Distrito o candidatos ");
                        Console.WriteLine("Favor ingrese Valores antes de continuar");
                        op = default(int);
                        Console.ReadKey();
                        Console.Clear();
                    }

                    break;
                case 3:
                    if (distrito != 0 && candidato != 0)
                    {
                        maxVoteCandidate = data.MaxValueVote(distrito, candidato);
                        topCandidate = data.topCandidato;
                        Console.WriteLine("El candidato que obtuvo la mayor cantidad de votos");
                        Console.WriteLine("es el candidato {0} con la suma de {1} votos", topCandidate, maxVoteCandidate);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No se a ingresado los valores de Distrito o candidatos ");
                        Console.WriteLine("Favor ingrese Valores antes de continuar");
                        op = default(int);
                        Console.ReadKey();
                        Console.Clear();
                    }

                    break;
                case 4:
                    if (distrito != 0 && candidato != 0)
                    {
                        int secondVoteCandidate = data.secondMaxvote;
                        int secondCandidate = data.topCandidato2;
                        Console.WriteLine("El segundo candidato que obtuvo la mayor cantidad de votos");
                        Console.WriteLine("es el candidato {0} con la suma de {1} votos", secondCandidate, secondVoteCandidate);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No se a ingresado los valores de Distrito o candidatos ");
                        Console.WriteLine("Favor ingrese Valores antes de continuar");
                        op = default(int);
                        Console.ReadKey();
                        Console.Clear();
                    }

                    break;
                case 5:
                    if (distrito != 0 && candidato != 0)
                    {
                        Console.WriteLine("Votos de candidatos por distrito");
                        Console.WriteLine("");
                        Console.WriteLine(data.PrintMatriz(distrito, candidato));
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("No se a ingresado los valores de Distrito o candidatos ");
                        Console.WriteLine("Favor ingrese Valores antes de continuar");
                        op = default(int);
                        Console.ReadKey();
                        Console.Clear();
                    }

                    break;
                case 6:
                    Console.Error.Close();
                    break;
                default:
                    Console.WriteLine("el valor ingresado no es valido dentro del menu favor ingrese nueva mente");
                    op = default(int);
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            return aux;
        }

        public void IntoDataForElection()
        {
            do
            {
                Console.WriteLine("Ingrese cantidad de distritos esto dentro de un rango de 5 a 7");
                var intoData = Console.ReadLine();
                if (validation.IsNumeric(intoData))
                {
                    distrito = int.Parse(intoData);

                    if (validation.RangeNumber(distrito, 5, 7))
                    {
                        Console.WriteLine("Se designaron {0} Distritos", distrito);
                    }
                    else
                    {
                        if (distrito > 7)
                        {
                            Console.WriteLine("El valor ingrezado es 'mayor' al limite designado para trabajar (7) ");
                        }
                        else
                        {
                            Console.WriteLine("El valor ingrezado es 'menor' al limite designado para trabajar (5) ");
                        }

                    }
                }
            } while (!validation.RangeNumber(distrito, 5, 7));

            ////////////////////////// divicion hecha para reconocer los parametros ingresados en el codigo
            do
            {
                Console.WriteLine("Ingrese cantidad de Candidato esto dentro de un rango de 3 a 5");
                var intoData2 = Console.ReadLine();
                if (validation.IsNumeric(intoData2))
                {
                    candidato = int.Parse(intoData2);

                    if (validation.RangeNumber(candidato, 3, 5))
                    {
                        Console.WriteLine("Se designaron {0} Candidato", candidato);
                    }
                    else
                    {
                        if (distrito > 5)
                        {
                            Console.WriteLine("El valor ingrezado es 'mayor' al limite designado para trabajar (7) ");
                        }
                        else
                        {
                            Console.WriteLine("El valor ingrezado es 'menor' al limite designado para trabajar (5) ");
                        }
                    }
                }
            } while (!validation.RangeNumber(candidato, 3, 5));


        }

    }
}
           
            