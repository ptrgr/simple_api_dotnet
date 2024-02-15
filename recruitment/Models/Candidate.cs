using System;
namespace recruitment.Models
{
	public class Candidate
	{


		public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
		public string ContactEmail { get; set; } = string.Empty;
		public string ContatNumber { get; set; } = string.Empty;

        public virtual List<Skill> Skills { get; set; } = new List<Skill>();


	}
}

