using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ePollAPI.Models
{
    public class Poll
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        //Foreign keys
        public List<Option> Options { get; set; }
    }
}
