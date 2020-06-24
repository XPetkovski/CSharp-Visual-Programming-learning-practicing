using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV7
{
    class WordSelector : IWordSelector
    {
        private readonly string[] words =
        {
            "Japan",
            "Germany",
            "Finland",
            "Sweden",
            "Iceland",
            "Norway",
            "Macedonia",
            "South Korea",
            "Italy",
            "America"
        };
        private Random random { get; set; }

        public WordSelector() { random = new Random(); }

        public string pick()
        {
            return words[random.Next(words.Length)];
        }

    }
}
