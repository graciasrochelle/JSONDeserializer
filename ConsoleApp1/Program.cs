using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        public const string BASE_URL = "https://api.myjson.com/bins/n1tmw";

        static List<FormsList> userForms = new List<FormsList>();
        static List<FormsList> UserForms { get; set; }
        static void Main(string[] args)
        {
            Console.Write("Heoofdnfe");
            tempAsync();
            Console.ReadLine();
        }

        public static async void tempAsync()
        {
            var t = await GetFormsAsync();
            UserForms = t;
            //Console.Write(t[0].AnswerSets[0].dueDate);
            UserForms.ForEach((forms) => {
            forms.AnswerSets.ForEach((answ) =>{
                Console.WriteLine(answ.dueDate);
            });

            });
        }

        public static async Task<List<FormsList>> GetFormsAsync()
        {
            using (var httpClient = new HttpClient())
            {
                var jsonString = await httpClient.GetStringAsync(BASE_URL);
                var forms = JsonConvert.DeserializeObject<List<FormsList>>(jsonString);
                return forms;
            }
        }
    }
}
