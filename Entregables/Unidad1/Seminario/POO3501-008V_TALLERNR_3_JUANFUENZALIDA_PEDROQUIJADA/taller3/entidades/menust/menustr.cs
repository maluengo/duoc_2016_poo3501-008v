using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades.menust
{
    public struct MenuStruct
    {
        public enum OpcionesMenu
        {
            IngresarCantidadDistritos = 1,
            IngresarCandidatos = 2,
            GenerarVotosAleatorios = 3,
            GanadorPrimerLugarVotaciones = 4,
            SegundoLugarVotaciones = 5,
            ImprimirVotacionGeneral = 6,
            Salir = 7
        }
    }
}
