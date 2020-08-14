using AutoMapper;
using ePollAPI.DTOs;
using ePollAPI.Models;
using ePollAPI.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePollAPI.Controllers
{
    //polls/
    [Route("[controller]")]
    [ApiController]
    public class PollsController : ControllerBase
    {
        private readonly IPollRepository _repository;
        private readonly IMapper _mapper;

        public PollsController(IPollRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET polls
        [HttpGet]
        public ActionResult<IEnumerable<PollDto>> GetAllPolls()
        {
            try
            {
                var polls = _repository.GetAllPolls();

                return Ok(_mapper.Map<IEnumerable<PollDto>>(polls));
            }
            catch(Exception e)
            {
                return StatusCode(500, "Poll listing error: " + e);
            }           
        }

        //GET polls/5
        [HttpGet("{id}")]
        public ActionResult<PollDetailDto> GetPollById(int id)
        {
            try
            {
                var poll = _repository.GetPollById(id);

                if (poll == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<PollDetailDto>(poll));
            }
            catch(Exception e)
            {
                return StatusCode(500, "Poll search error: " + e);
            }
            
        }

        //POST polls/add
        [HttpPost("add")]
        public ActionResult<PollDetailDto> CreatePoll(PollCreateDto pollCreateDto)
        {           
            try
            {
                //Map Poll models properties to pollCreateDto
                var pollModel = _mapper.Map<Poll>(pollCreateDto);

                _repository.CreatePoll(pollModel);
                _repository.SaveChanges();

                //Map Poll models properties to PollDetailDto
                var pollReadDto = _mapper.Map<PollDetailDto>(pollModel);
            
                return Ok(pollReadDto);
            }
            catch(Exception e)
            {
                return StatusCode(500, "Poll creation error: " + e);
            }                      
        }

        //POST polls/5/vote/5
        [HttpPost("{id}/vote/{option}")]
        public ActionResult<PollDetailDto> VotePoll(int id, int option)
        {
            try
            {
                //Search the requested poll {id}
                var poll = _repository.GetPollById(id);

                if (poll == null)
                {
                    return NotFound();
                }

                //Comment: Error (Access violation) if put in repository?
                foreach (var choice in poll.Options.Where(o => o.OptionNo == option))
                {
                    choice.Votes++;
                }             

                _repository.SaveChanges();

                return Ok(_mapper.Map<PollDetailDto>(poll));
            }
            catch(Exception e)
            {
                return StatusCode(500, "Voting error: " + e);
            }            
        }
    }
}
