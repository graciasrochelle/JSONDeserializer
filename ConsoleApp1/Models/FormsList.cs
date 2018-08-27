using ConsoleApp1.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1.Models
{ 
    public class FormsList
    {
        [JsonProperty("id")]
        public string ID { get; set; }
        [JsonProperty("userID")]
        public string UserID { get; set; }
        [JsonProperty("formID")]
        public string FormID { get; set; }
        [JsonProperty("form")]
        public Form Form { get; set; }
        [JsonProperty("schedule")]
        public string Schedule { get; set; }
        [JsonProperty("repitition")]
        public int Repetition { get; set; }
        [JsonProperty("answerSet")]
        public List<AnswerSet> AnswerSets { get; set; }
    }
}
