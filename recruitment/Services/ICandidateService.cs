namespace recruitment.Services
{
    public interface ICandidateService
    {
     
        List<Candidate> GetAllCandidates();
        Candidate GetSingleCandidate(int id);
        List<Candidate> AddCandidate(Candidate candidate);
        List<Candidate> DeleteCandidate(int id);
    }
}
