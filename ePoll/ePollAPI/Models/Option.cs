using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ePollAPI.Models
{
    public class Option
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        [JsonPropertyName("id")]
        public int OptionNo { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        public int Votes { get; set; } = 0;

        
        //Foreign keys
        [ForeignKey("Poll")]
        [JsonIgnore]
        public int PollId { get; set; }

        //Navigation
        [JsonIgnore]
        public Poll Poll { get; set; }
    }
}