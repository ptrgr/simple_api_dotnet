
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace recruitment.Services
{
    public class CandidateService : ICandidateService
    {

        private readonly CandidateDbContext _candidateDbContext;

        public CandidateService(CandidateDbContext candidateDbContext)
        {
            _candidateDbContext = candidateDbContext;
        }

        public async Task<List<Candidate>> AddCandidate(Candidate candidate)
        {
            _candidateDbContext.Candidates.Add(candidate);
            await _candidateDbContext.SaveChangesAsync();
            return await _candidateDbContext.Candidates.ToListAsync();

         
        }


        public async Task<List<Candidate>?> DeleteCandidate(int id)
        {
            var candidate = await _candidateDbContext.Candidates.FindAsync(id);
            if (candidate == null)
            {
                throw new ArgumentException("Kandydat o podanym identyfikatorze nie istnieje.");
            }
            _candidateDbContext.Candidates.Remove(candidate);
            await _candidateDbContext.SaveChangesAsync();
            return await _candidateDbContext.Candidates.ToListAsync();
        }

        public async Task<List<Candidate>> GetAllCandidates()
        {
            var candidateList = await _candidateDbContext.Candidates.ToListAsync();
            return candidateList;
        }

        public async Task<Candidate?> GetSingleCandidate(int id)
        {
            var candidate = await _candidateDbContext.Candidates.FindAsync(id);
            if (candidate == null)
            {
                throw new ArgumentException("Kandydat o podanym identyfikatorze nie istnieje.");
            }
            return candidate;
        }
    }
}
