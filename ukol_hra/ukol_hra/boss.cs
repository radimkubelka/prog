using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ukol_hra
{
    internal class Boss
    {
        public string name;
        public string difficulty;
        public string topic;
        public Boss(string name, string difficulty, string topic)
        {
            this.name = name;
            this.difficulty = difficulty;
            this.topic = topic;
        }
        public int AskWithOptions(string question, string canswer, string option1, string option2, string option3)
        {
            Console.WriteLine(question);
            Console.WriteLine("Možnosti:");
            Console.WriteLine($"1. {option1}");
            Console.WriteLine($"2. {option2}");
            Console.WriteLine($"3. {option3}");
            if (Console.ReadLine() == canswer)
            {
                Console.WriteLine($"Správná odpověď. ");
                return 1;
            }
            else
            {
                Console.WriteLine($"Tohle bouhžel není správně. Správná odpověď je: {canswer}.");
                return 0;
            }
        }
    }
}
