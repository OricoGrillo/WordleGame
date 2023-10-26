using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WordleGame
{
    public class DeserializeJson
    {
        // This method returns a bunch of valid words array.
        public List<string> GetValidWords()
        {
            string path = @".\ValidWords.json";
            List<string>? jsonwords;
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var json = jsonStream.ReadToEnd();
                jsonwords = JsonConvert.DeserializeObject<List<string>>(json);
            }
            return jsonwords;
        }
    }
}
