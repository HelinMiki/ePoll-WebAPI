using ePollAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ePollAPI.DTOs
{
    public class PollDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Option> Options { get; set; }
    }
}
