using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_hra
{
    internal class Program
    {
        static void Wrong()
        {
            Console.WriteLine("Je mi líto, ale toto není správná odpověď.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vítej v příběhové kvízové hře. Ovládání je jednoduché. Pouze odpovídej na otázky. Když budeš mít na výběr z několika odpovědí, odpověz číslem u té tebou zvolené. Jinak svou odpověď prostě napiš. (Pozor na spelling a gramatiku - musíš psát i háčky a čárky)");
            Console.WriteLine();
            Console.WriteLine("Než začneme, zvol si své jméno");
            string name = Console.ReadLine();
            Player hero = new Player(0);
            hero.name = name;
            Console.WriteLine();


            Console.WriteLine($"Vítej v našem světě {hero.name}. Čeká tě složitá cesta, ale za její úspěšné projití tě čeká věčná sláva. Jěště tě musím varovat. Mnoho odvážlivců tuto cestu zkoušelo, ale zatím žádný se nedožil jejího konce. Chceš opravdu riskovat svůj život pro věčnou slávu?");
            Console.WriteLine("1. ano");
            Console.WriteLine("2. Ne, nakonec jsem si to rozmyslel.");
            if (Console.ReadLine() == "2")
            {
                Console.WriteLine("Jak myslíš, tak si pokračuj ve svém nezajímavém životě.");
                Console.ReadKey();
                return;
            }


            Console.WriteLine();
            Console.WriteLine("Vidím, že jsi odvážný. Ale odvaha samotná ti tu stačit nebude. To nejhlavnější jsou znalosti. Po své cestě budeš potkávat mnoho lidí a každý se tě bude na něco ptát. Budou to otázky ze všech možných témat, takže se nemusíš bát, že by někdo byl ve víhodě. Teď už je čas, abys ses vydal na cestu. Nebo se snad chceš na neco ještě zeptat?");
            Console.WriteLine("1. Ne");
            Console.WriteLine("2. Kdo jsi ty?");
            if (Console.ReadLine() == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Já už nejsem nikdo. Dřív jsem byl jako ty a snažil se dostat na konec této cesty, ale neuspěl jsem. Teď musím navěky sloužit mému pánu a pomáhat novým dobrodruhům");
            }
            Console.WriteLine();
            Console.WriteLine("Vydal ses na cestu a hned na konci vesnice přichází první hádankář");


            Npc npc1 = new Npc("Karel", "lehká", "jazyk", 1);
            Console.WriteLine();
            Console.WriteLine($"Ahoj, já jsem {npc1.name} a kždému dávám jeho první otázku. Moje úroveň je {npc1.difficulty}, zaměřuji se na {npc1.topic} a za správnou odpověď dostaneš {npc1.points} bod.");


            Console.ReadKey();
        }
    }
}
