using System.Text.Json.Serialization;

namespace ePollAPI.DTOs
{
    public class OptionDto
    {
        [JsonPropertyName("id")]
        public int OptionNo { get; set; }

        public string Title { get; set; }


        //Foreign keys
        [JsonIgnore]
        public int PollId { get; set; }


        //Navigation
        [JsonIgnore]
        public PollDetailDto PollDetailDto { get; set; }
        [JsonIgnore]
        public PollCreateDto PollCreateDto { get; set; }



        //[JsonIgnore]
        //public PollDto PollDto { get; set; }
    }
}
