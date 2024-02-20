namespace recruitment.Services
{
    public interface ICandidateService
    {
     
        Task<List<Candidate>> GetAllCandidates();
        Task<Candidate?> GetSingleCandidate(int id);
        Task<List<Candidate>> AddCandidate(Candidate candidate);
        Task<List<Candidate>?> DeleteCandidate(int id);
    }
}
