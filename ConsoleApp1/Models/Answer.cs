using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Answer
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("id")]
        public string QuestionID { get; set; }

        [JsonProperty("id")]
        public Question Questions { get; set; }

        [JsonProperty("id")]
        public string Response { get; set; }
    }
}
