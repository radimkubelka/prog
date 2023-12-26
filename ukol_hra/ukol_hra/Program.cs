using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_hra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Než začneme, zvol si své jméno");
            string name = Console.ReadLine();
            player hero = new player();
            hero.name = name;
            Console.WriteLine($"Vítej v našem světě {hero.name}. Čeká tě složitá cesta, ale za její úspěšné projití tě čeká věčná sláva. Jěště tě musím varovat. Mnoho odvážlivců tuto cestu zkoušelo, ale zatím žádný se nedožil jejího konce. Chceš opravdu riskovat svůj život pro věčnou slávu?");
            string bravery = Console.ReadLine();
            if (bravery == "ne")
                {
                return;
                }





            Console.ReadKey();
        }
    }
}
