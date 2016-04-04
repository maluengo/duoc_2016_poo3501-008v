namespace voteapp.backend.entities.Enums
{
    public struct MenuStruct
    {
        /// <summary>
        /// Conjunto de constantes que indica, a través de un enumerador, las opciones del menú.  Mapeables diréctamente a INT. 
        /// </summary>
        public enum MenuOptionsEnum
        {
            IngresarCantidadDistritos,
            IngresarCandidatos,
            GenerarVotosAleatorios,
            GanadorPrimerLugarVotaciones,
            SegundoLugarVotaciones,
            ImprimirVotacionGeneral,
            Salir
        }
    }
}
