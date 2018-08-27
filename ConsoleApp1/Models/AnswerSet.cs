using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class AnswerSet
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("userFormID")]
        public string userFormID { get; set; }
        [JsonProperty("dueDate")]
        public string dueDate { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }

        //public int Iteration { get; set; }
        //public int Progress { get; set; }
        //public List<Answer> Answers { get; set; }
    }
}
