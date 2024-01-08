using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukol_hra
{
    internal class Program
    {
        static int AntiFall()
        {
            int answer = 0;
            while (answer != 1 && answer != 2)
            {
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    if (answer == 1 || answer == 2)
                    {
                        return answer;
                    }
                    else
                    {
                        Console.WriteLine("zadej platnou možnost");
                    }
                }
                else 
                {
                    Console.WriteLine("zadej platnou možnost");
                }
            }
            return -1;
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
            int answer = AntiFall();
            if (answer == 2)
            {
                Console.WriteLine("Jak myslíš, tak si pokračuj ve svém nezajímavém životě.");
                Console.ReadKey();
                return;
            }


            Console.WriteLine();
            Console.WriteLine("Vidím, že jsi odvážný. Ale odvaha samotná ti tu stačit nebude. To nejhlavnější jsou znalosti. Po své cestě budeš potkávat mnoho lidí a každý se tě bude na něco ptát. Budou to otázky ze všech možných témat, takže se nemusíš bát, že by někdo byl ve víhodě. Teď už je čas, abys ses vydal na cestu. Nebo se snad chceš na neco ještě zeptat?");
            Console.WriteLine("1. Ne");
            Console.WriteLine("2. Kdo jsi ty?");
            answer = AntiFall();
            if (answer == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Já už nejsem nikdo. Dřív jsem byl jako ty a snažil se dostat na konec této cesty, ale neuspěl jsem. Teď musím navěky sloužit mému pánu a pomáhat novým dobrodruhům");
            }
            Console.WriteLine();
            Console.WriteLine("Vydal ses na cestu a hned na konci vesnice přichází první hádankář");


            Npc npc1 = new Npc("Karel", "lehká", "jazyk", 1);
            Console.WriteLine();
            Console.WriteLine($"Ahoj, já jsem {npc1.name} a kždému dávám jeho první otázku. Moje úroveň je {npc1.difficulty}, zaměřuji se na {npc1.topic} a za správnou odpověď dostaneš {npc1.points} bod.");
            if (npc1.AskWithOptions("Jaké je první písmeno abecedy?", 3, "d", "t", "a") == 1)
            {
                hero.kp += npc1.points;
            }
            else
            {
                hero.kp -= npc1.points;
            }
            Console.WriteLine();


            Console.WriteLine("Svou prví otázku máš za sebou a pokračuješ dál. Je poznat, že tuto cestu zkouší opravdu hodně lidí, protože je cesta hezky udržovaná a zároveň i plná stop. Jdeš polem, které za chvíli končí u lesa a hned u prvního stromu stojí další hádankář.");
            Npc npc2 = new Npc("Adrian", "lehká", "zeměpis", 1);
            Console.WriteLine($"Mé jméno je {npc2.name}. Jsem správce místního lesa a za svou službu jsem získal již mnoho vědomostí. Než tě pustím do lesa, tak si tě vyzkouším z tématu {npc2.topic} s obtížností {npc2.difficulty}. To se ti bude při cestování pořádně hodit. Moje body jsou {npc2.points}");
            if (npc2.Ask("Kolik má USA států?", "50") == 1)
            {
                hero.kp += npc2.points;
            }
            else
            {
                hero.kp -= npc2.points;
            }
            Console.WriteLine();


            Npc npc3 = new Npc("Eduard", "lehká", "Sport", 1);
            Npc npc4 = new Npc("Josef", "střední", "Matematika", 2);
            Npc npc5 = new Npc("Luboš", "těžká", "Dějepis", 3);
            Console.WriteLine("Tvá cesta se přesunula do prostředí lesa. Oproti poli tu je krásný chládek a zvuky lesa jsou opravdu uklidňující. Najednou slyšíš lidské hlasy. Jsou to tři houbaři. Chvíli si spolu povídáte a říkají, že to jsou opravdu vášniví houbaři z nedaleké vesnice a nabízejí ti lesní jahody, co našli.");
            Console.WriteLine("1. Vzít si jahody.");
            Console.WriteLine("2. Odmítnout");
            answer = AntiFall();
            if (answer == 1)
            {
                Console.WriteLine("Mňam, mňam");
            }
            else
            {
                Console.WriteLine("Houbaři se trochu podivili a snědli je sami.");
            }
            Console.WriteLine("Ukáže se, že houbaři jsou taky hádankáři a každý ti teď položí otázku.");
            Console.WriteLine($"Já jsem první z houbařů a jmenuji se {npc3.name}. Dám ti otázku z tématu {npc3.topic} s obžností {npc3.difficulty}. moje body jsou  {npc3.points}");
            /*if (npc3.Ask() == 1)
            {
                hero.kp += npc3.points;
            }
            else
            {
                hero.kp -= npc3.points;
            }

            if (npc4.AskWithOptions() == 1)
            {
                hero.kp += npc4.points;
            }
            else
            {
                hero.kp -= npc4.points;
            }

            if (npc5.AskWithOptions() == 1)
            {
                hero.kp += npc5.points;
            }
            else
            {
                hero.kp -= npc5.points;
            }*/
            Console.WriteLine();


            Console.WriteLine("Postupuješ hlouběji do lesa a korunami stromů se prodírá na zem pořád méně a méně světla. Až do téhle chvíle tě ani nenapdalo, že by tě na téhle cestě mohlo něco překvapit. Najednou se tě však zmáhá pocit, že toto není jen tak ledajaká cesta a že tě čeká něco velmi děsivého. Před tebou se v dáli objeví chaloupka. V oknech se svítí a tak vejdeš dovnitř doufaje, že si tam budeš moct odpočinout. Přivítá tě stará babička.");
            Npc npc6 = new Npc("Hexana", "střední", "Biologie", 2);
            Console.WriteLine($"Zdravím tě {hero.name}. Doufám že moc nespěcháš a chvíli tu pobudeš, abych si s tebou mohla popovídat.");
            Console.WriteLine("1. Bohužel spěchám.");
            Console.WriteLine("2. Ne, nespěchám. Už jdou dlouhou dobu, takže trocha odpočinku mi prospěje.");
            answer = AntiFall();
            if (answer == 1)
            {
                Console.WriteLine($"To je škoda. Přišel jsi o zajímavé informace. Ale co se dá dělat. Však než tě pustím zpátky na tvoji cestu, tak tu položím jednu otázku. Bude {npc6.difficulty} obtížnosti a z okruhu {npc6.topic}");
            }
            else
            {
                Console.WriteLine($"To jsem ráda. Začnu tím, kdo jsem. Nejsem totiž obyčejná stařenka. Jmenuji se {npc6.name} a jsem čarodejnice. Nemusíš se mě však bát. Toto není normální cesta a proto budeš potkávat nadpřirozené bytosti. Nikdo z nich ti však neublíží, pouze se zeptá na otázku tak jako já. Snad ji budeš vědět a hezkou cestu.");
            }
            if (npc6.AskWithOptions() == 1)
            {
                hero.kp += npc4.points;
            }
            else
            {
                hero.kp -= npc4.points;
            }








            Console.WriteLine(hero.kp);
            Console.ReadKey();
        }
    }
}
