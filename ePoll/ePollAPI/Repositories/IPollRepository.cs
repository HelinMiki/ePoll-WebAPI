using ePollAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePollAPI.Repositories
{
    public interface IPollRepository
    {
        bool SaveChanges();

        IEnumerable<Poll> GetAllPolls();
        Poll GetPollById(int id);
        void CreatePoll(Poll p);
    }
}
