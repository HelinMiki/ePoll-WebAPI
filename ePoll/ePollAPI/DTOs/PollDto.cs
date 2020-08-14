using ePollAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ePollAPI.DTOs
{
    public class PollDto
    {
        public int Id {  get; set; }

        public string Title {  get; set; }
    }
}
