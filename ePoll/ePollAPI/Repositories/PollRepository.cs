using ePollAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ePollAPI.Repositories
{
    public class PollRepository : IPollRepository
    {
        //Database constructor
        private readonly PollDbContext _context;

        public PollRepository(PollDbContext context)
        {
            _context = context;
        }
       
        //Add a new poll into the database
        public void CreatePoll(Poll newPoll)
        {
            if (newPoll == null)
            {
                throw new ArgumentNullException(nameof(newPoll));
            }

            var poll = new Poll { Id = newPoll.Id };
            poll.Title = newPoll.Title;
            poll.Options = new List<Option>();

            //Insert newPoll's options into poll's list of options
            foreach(var opt in newPoll.Options)
            {
                opt.OptionNo = poll.Options.Count() + 1;
                opt.Votes = 0;
                poll.Options.Add(opt);
            }
         
            _context.Polls.Add(poll);                                        
        }

        //List all polls
        public IEnumerable<Poll> GetAllPolls()
        {           
            return _context.Polls.ToList();           
        }

        //Search a poll by its property "Id" and include its options into the search.
        public Poll GetPollById(int id)
        {
            return _context.Polls.Include(o => o.Options)
                                 .FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
