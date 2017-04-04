using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// https://es.wikipedia.org/wiki/Objeto_de_Transferencia_de_Datos_%28DTO%29
    /// </summary>
    public class CandidatosDTO
    {
            public string CandidatosMatriz { get; set; }
            public int[] ContadorVotos { get; set; }        
    }
}
