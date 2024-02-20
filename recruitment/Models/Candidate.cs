using System;
using System.Reflection.Metadata;
namespace recruitment.Models
{
	public class Candidate
	{

		public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
		public string ContactEmail { get; set; }
		public string ContatNumber { get; set; }
        public Address? Address { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }

        public virtual List<Skill> Skills { get; set; } = new List<Skill>();

    }
}

