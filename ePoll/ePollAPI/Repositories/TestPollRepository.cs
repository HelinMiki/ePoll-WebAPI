using ePollAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePollAPI.Repositories
{
    public class TestPollRepository : IPollRepository
    {
        public void CreatePoll(Poll p)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Poll> GetAllPolls()
        {
            var polls = new List<Poll>
            {
                new Poll { Id = 101, Title = "GetAllPolls1" },
                new Poll { Id = 102, Title = "GetAllPolls2" },
                new Poll { Id = 103, Title = "GetAllPolls3" } 
            };

            return polls;
        }

        public Poll GetPollById(int id)
        {
            return new Poll { Id = 100, Title = "GetPollById" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void VotePoll(int id, int option)
        {
            throw new NotImplementedException();
        }
    }
}
