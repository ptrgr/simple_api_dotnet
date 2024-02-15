
namespace recruitment.Services
{
    public class CandidateService : ICandidateService
    {
        private static List<Candidate> candidates = new List<Candidate> {
            new Candidate
            {
                Id = 1,
                Name = "Piotr",
                LastName = "G",
                ContactEmail = "p@pl",
                ContatNumber = "789654123",
                Skills = new List<Skill> {
                    new Skill { Id = 1, Name = "React" },
                    new Skill { Id = 2, Name = "Js" }
                },
            },
            new Candidate
            {
                Id = 2,
                Name = "Paweł",
                LastName = "P",
                ContactEmail = "p@pl",
                ContatNumber = "789654123",
                Skills = new List<Skill> {
                    new Skill { Id = 3, Name = "SQL" },
                    new Skill { Id = 4, Name = "PHP" }
                },
            },
            new Candidate
            {
                Id = 3,
                Name = "Gaweł",
                LastName = "R",
                ContactEmail = "p@pl",
                ContatNumber = "789654123",
                Skills = new List<Skill> {
                    new Skill { Id = 5, Name = "C" },
                    new Skill { Id = 2, Name = "Js" }
                },
            }
        };

        private static List<Skill> skills = new List<Skill> {
            new Skill { Id = 1, Name = "React" },
            new Skill { Id = 2, Name = "Js" },
            new Skill { Id = 3, Name = "SQL" },
            new Skill { Id = 4, Name = "PHP" },
            new Skill { Id = 5, Name = "C" }
        };
        public List<Candidate> AddCandidate(Candidate candidate)
        {
            candidates.Add(candidate);

            return candidates;
        }

   

        public List<Candidate> DeleteCandidate(int id)
        {
            var candidate = candidates.Find(person => person.Id == id);
            if (candidate == null)
            {
                throw new ArgumentException("Kandydat o podanym identyfikatorze nie istnieje.");
            }
            candidates.Remove(candidate);
            return candidates;
        }

        public List<Candidate> GetAllCandidates()
        {
            return candidates;
        }

        public Candidate GetSingleCandidate(int id)
        {
            var candidate = candidates.Find(person => person.Id == id);
            if (candidate == null)
            {
                throw new ArgumentException("Kandydat o podanym identyfikatorze nie istnieje.");
            }
            return candidate;
        }
    }
}
