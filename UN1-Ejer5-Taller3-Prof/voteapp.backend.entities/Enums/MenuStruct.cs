namespace voteapp.backend.entities.Enums
{
    public struct MenuStruct
    {
        /// <summary>
        /// Conjunto de constantes que indica, a través de un enumerador, las opciones del menú.  Mapeables diréctamente a INT. 
        /// </summary>
        public enum MenuOptionsEnum
        {
            IngresarCantidadDistritos=1,
            IngresarCandidatos=2,
            GenerarVotosAleatorios=3,
            GanadorPrimerLugarVotaciones=4,
            SegundoLugarVotaciones=5,
            ImprimirVotacionGeneral=6,
            Salir=7
        }
    }
}
