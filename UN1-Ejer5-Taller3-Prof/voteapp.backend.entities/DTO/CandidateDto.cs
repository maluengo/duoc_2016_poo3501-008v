namespace voteapp.backend.entities.DTO
{
    public class CandidateDto
    {
        /// <summary>
        /// Nombre del candidato. 
        /// </summary>
        public string CandidateName { get; set; }

        /// <summary>
        /// Propiedad que guarda los distritos y cada voto por cada uno de éstos. 
        /// </summary>
        public VoteDto VotesByDistrite { get; set; }
    }
}
