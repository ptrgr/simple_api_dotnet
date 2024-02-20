using System;
namespace recruitment.Models
{
	public class Skill
	{
	
		public int Id { get; set; }
		public string Name { get; set; }

		public List<Candidate> Candidates { get; set; }
		
    }
}

