using System;
using Newtonsoft.Json;

namespace ConsoleApp1.Models
{
    public class Question
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("options")]
        public string Options { get; set; }
    }
}
