namespace voteapp.backend.entities.DTO
{
    public class CandidateDto
    {
        public string CandidateName { get; set; }
        
        public VoteDto VotesByDistrite { get; set; }
    }
}
