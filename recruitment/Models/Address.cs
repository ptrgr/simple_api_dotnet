namespace recruitment.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public Candidate Candidate { get; set; }
        public int CandidateId { get; set; }
    }
}
