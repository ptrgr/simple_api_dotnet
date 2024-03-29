﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Matching;
using recruitment.Services;


namespace recruitment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService _candidateService;
        public CandidateController(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Candidate>>> GetAllCandidates()
        {
            var result = _candidateService.GetAllCandidates();
            if (result == null)
            {
                return NotFound("Brak kandydatów");
            }
            return Ok(result);
         
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Candidate>> GetSingleCandidate(int id)
        {
            var result = _candidateService.GetSingleCandidate(id);
            if (result == null)
            {
                return NotFound("Brak kandydata");
            }
            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult<List<Candidate>>> AddCandidate(Candidate newCandidate)
        {
            var result = _candidateService.AddCandidate(newCandidate);
          
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Candidate>>> DeleteCandidate(int id)
        {
           var result = _candidateService.DeleteCandidate(id);
            if (result == null)
            {
                return NotFound("Brak kandydata");
            }
           return Ok(result);
        }


    }
}
