using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Operations
{
    public class ManejoString
    {
        public string agregarEspacios(string cadena, int largoTotal, int espaciosAntes)
        {
            if (string.IsNullOrEmpty(cadena))
            {
                cadena = " ";
            }
            if (largoTotal > 0)
            {
                if (cadena.Length < largoTotal)
                {
                    int largoActual = cadena.Length;
                    for (int iAntes = 0; iAntes < espaciosAntes; iAntes++)
                    {
                        cadena = " " + cadena;
                    }
                    for (int i = 0; i < (largoTotal - cadena.Length); i++)
                    {
                        cadena += " ";
                    }
                }
            }
            return cadena;
        }
    }
}
