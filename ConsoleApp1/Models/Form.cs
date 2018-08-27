using System.Collections.Generic;
using Newtonsoft.Json;
using ConsoleApp1.Models;

namespace ConsoleApp1.Models
{
    public class Form
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("toBeFilledBy")]
        public string ToBeFilledBy { get; set; }

        [JsonProperty("questions")]
        public List<Question> Questions { get; set; }
    }
}
