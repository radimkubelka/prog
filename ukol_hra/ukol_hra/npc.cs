using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_hra
{
    internal class Npc
    {
        public string name;
        public string difficulty;
        public string topic;
        public int points;
        public Npc(string name, string difficulty, string topic, int points)
        { 
            this.name = name;
            this.difficulty = difficulty;
            this.topic = topic;
            this.points = points;
        }
        public int DumbTest()
        {
            int answer = 0;
            while (answer != 1 && answer != 2 && answer != 3)
            {
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    if (answer == 1 || answer == 2 || answer == 3)
                    {
                        return answer;
                    }
                    else
                    {
                        Console.WriteLine("zadej platnou možnost (1, 2 nebo 3)");
                    }
                }
                else
                {
                    Console.WriteLine("zadej platnou možnost (1, 2 nebo 3)");
                }
            }
            return -1;
        }
        public int Ask(string question, string canswer)
        {
            Console.WriteLine(question);
            if (Console.ReadLine() == canswer)
            {
                Console.WriteLine($"Správná odpověď. Získáváš moje body ({points}) a můžeš pokračovat dál.");
                return 1;
            }
            else
            {
                Console.WriteLine($"Tohle bouhžel není správně. Správná odpověď je: {canswer}. Beru si od tebe body (-{points}).");
                return 0;
            }
        }
        public int AskWithOptions(string question, int canswer,string option1, string option2, string option3)
        {
            Console.WriteLine(question);
            Console.WriteLine("Možnosti:");
            Console.WriteLine($"1. {option1}");
            Console.WriteLine($"2. {option2}");
            Console.WriteLine($"3. {option3}");
            int imput = DumbTest();
            if (imput == canswer)
            {
                Console.WriteLine($"Správná odpověď. Získáváš moje body ({points}) a můžeš pokračovat dál.");
                return 1;
            }
            else
            {
                Console.WriteLine($"Tohle bouhžel není správně. Správná odpověď je: {canswer}. Beru si od tebe body (-{points}).");
                return 0;
            }
        }
    }
}
