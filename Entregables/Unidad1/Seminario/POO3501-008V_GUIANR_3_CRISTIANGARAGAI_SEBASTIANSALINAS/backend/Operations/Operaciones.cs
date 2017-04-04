using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Operations
{
    public class Operaciones
    {
        public int getMayorDeArreglo(int[] arreglo)
        {
            int indice = default(int);
            if (arreglo != null)
            {
                int mayor = default(int);
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (arreglo[i] > mayor)
                    {
                        mayor = arreglo[i];
                        indice = i;
                    }
                }
            }
            else
            {
                indice = -1;
            }
            return indice;
        }

        public int getSegundoDeArreglo(int[] arreglo)
        {
            int indice = default(int);
            if (arreglo != null)
            {
                int mayor = default(int);
                int mayorActual = getMayorDeArreglo(arreglo);
                for (int i = 0; i < arreglo.Length; i++)
                {
                    if (i != mayorActual)
                    {
                        if (arreglo[i] > mayor)
                        {
                            mayor = arreglo[i];
                            indice = i;
                        }
                    }
                }
            }
            else
            {
                indice = -1;
            }
            return indice;
        }
    }
}
