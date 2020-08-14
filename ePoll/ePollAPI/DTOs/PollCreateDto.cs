using ePollAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePollAPI.DTOs
{
    public class PollCreateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public List<Option> Options { get; set; }
    }
}
