using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ukol_hra
{
    internal class Program
    {
        //aby hráč zadal jen 1 nebo 2
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
            if (AntiFall() == 2)
            {
                Console.WriteLine("Jak myslíš, tak si pokračuj ve svém nezajímavém životě.");
                Console.ReadKey();
                return;
            }


            Console.WriteLine();
            Console.WriteLine("Vidím, že jsi odvážný. Ale odvaha samotná ti tu stačit nebude. To nejhlavnější jsou znalosti. Po své cestě budeš potkávat mnoho lidí a každý se tě bude na něco ptát. Budou to otázky ze všech možných témat, takže se nemusíš bát, že by někdo byl ve výhodě. Teď už je čas, aby ses vydal na cestu. Nebo se snad chceš na něco ještě zeptat?");
            Console.WriteLine("1. Ne");
            Console.WriteLine("2. Kdo jsi ty?");
            if (AntiFall() == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Já už nejsem nikdo. Dřív jsem byl jako ty a snažil se dostat na konec této cesty, ale neuspěl jsem. Teď musím navěky sloužit mému pánu a pomáhat novým dobrodruhům");
            }
            Console.WriteLine();
            Console.WriteLine("Vydal ses na cestu a hned na konci vesnice přichází první hádankář");


            Npc npc1 = new Npc("Karel", "lehká", "jazyk", 1);
            Console.WriteLine();
            Console.WriteLine($"Ahoj, já jsem {npc1.name} a každému dávám jeho první otázku. Moje úroveň je {npc1.difficulty}, zaměřuji se na {npc1.topic} a za správnou odpověď dostaneš {npc1.points} bod.");
            if (npc1.AskWithOptions("Jaké je první písmeno abecedy?", 3, "d", "t", "a") == 1)
            {
                hero.kp += npc1.points;
                npc1.correct = true;
            }
            else
            {
                hero.kp -= npc1.points;
                
            }
            Console.WriteLine();


            Console.WriteLine("Svou prví otázku máš za sebou a pokračuješ dál. Je poznat, že tuto cestu zkouší opravdu hodně lidí, protože je cesta hezky udržovaná a zároveň i plná stop. Jdeš polem, které za chvíli končí u lesa a hned u prvního stromu stojí další hádankář.");
            Npc npc2 = new Npc("Adrian", "lehká", "zeměpis", 1);
            bool q2 = false;
            Console.WriteLine($"Mé jméno je {npc2.name}. Jsem správce místního lesa a za svou službu jsem získal již mnoho vědomostí. Než tě pustím do lesa, tak si tě vyzkouším z tématu {npc2.topic} s obtížností {npc2.difficulty}. To se ti bude při cestování pořádně hodit. Moje body jsou {npc2.points}");
            if (npc2.Ask("Kolik má USA států?", "50") == 1)
            {
                hero.kp += npc2.points;
                npc2.correct = true;
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
            if (AntiFall() == 1)
            {
                Console.WriteLine("Mňam, mňam");
            }
            else
            {
                Console.WriteLine("Houbaři se trochu podivili a snědli je sami.");
            }
            Console.WriteLine();
            Console.WriteLine("Ukáže se, že houbaři jsou taky hádankáři a každý ti teď položí otázku.");
            Console.WriteLine();
            Console.WriteLine($"Já jsem první z houbařů a jmenuji se {npc3.name}. Dám ti otázku z tématu {npc3.topic} s obžností {npc3.difficulty}. moje body jsou  {npc3.points}");
            if (npc3.Ask("Kolik celých kilometrů má maraton?", "42") == 1)
            {
                hero.kp += npc3.points;
                npc3.correct = true;
            }
            else
            {
                hero.kp -= npc3.points;
            }

            Console.WriteLine();
            Console.WriteLine($"Já jsem druhý houbař {npc4.name}. Dám ti otázku z tématu {npc4.topic} s obžností {npc4.difficulty}.");
            if (npc4.AskWithOptions("O jakém tvaru jsou Euklidovy věty?", 2, "Kruh", "Trojúhelník", "Lichoběžník") == 1)
            {
                hero.kp += npc4.points;
                npc4.correct = true;
            }
            else
            {
                hero.kp -= npc4.points;
            }

            Console.WriteLine();
            Console.WriteLine($"Já jsem druhý houbař {npc5.name}. Dám ti otázku z tématu {npc5.topic} s obžností {npc5.difficulty}.");
            if (npc5.AskWithOptions("Jaká dynastie vládla na českém trůně po Přemyslovcích", 3, "Habsburkové", "Jagellonci", "Lucemburkové") == 1)
            {
                hero.kp += npc5.points;
                npc5.correct = true;
            }
            else
            {
                hero.kp -= npc5.points;
            }
            Console.WriteLine();


            Console.WriteLine("Postupuješ hlouběji do lesa a korunami stromů se prodírá na zem pořád méně a méně světla. Až do téhle chvíle tě ani nenapadalo, že by tě na téhle cestě mohlo něco překvapit. Najednou se tě však zmáhá pocit, že toto není jen tak ledajaká cesta a že tě čeká něco velmi děsivého. Před tebou se v dáli objeví chaloupka. V oknech se svítí a tak vejdeš dovnitř doufaje, že si tam budeš moct odpočinout. Přivítá tě stará babička.");
            Npc npc6 = new Npc("Hexana", "těžká", "Biologie", 3);
            Console.WriteLine($"Zdravím tě {hero.name}. Doufám, že moc nespěcháš a chvíli tu pobudeš, abych si s tebou mohla popovídat.");
            Console.WriteLine("1. Bohužel spěchám.");
            Console.WriteLine("2. Ne, nespěchám. Už jdu dlouhou dobu, takže trocha odpočinku mi prospěje.");
            if (AntiFall() == 1)
            {
                Console.WriteLine($"To je škoda. Přišel jsi o zajímavé informace. Ale co se dá dělat. Však než tě pustím zpátky na tvoji cestu, tak ti položím jednu otázku. Bude obtížnosti {npc6.difficulty} a z okruhu {npc6.topic}");
            }
            else
            {
                Console.WriteLine($"To jsem ráda. Začnu tím, kdo jsem. Nejsem totiž obyčejná stařenka. Jmenuji se {npc6.name} a jsem čarodejnice. Nemusíš se mě však bát. Toto není normální cesta a proto budeš potkávat nadpřirozené bytosti. Nikdo z nich ti však neublíží, pouze se zeptá na otázku tak jako já. Snad ji budeš vědět a hezkou cestu.");
            }
            Console.WriteLine();
            if (npc6.AskWithOptions("Co je babské ucho?", 1, "Šalvěj", "Choroš", "Pampeliška") == 1)
            {
                hero.kp += npc6.points;
                npc6.correct = true;
            }
            else
            {
                hero.kp -= npc6.points;
            }
            Console.WriteLine("1. Odejít");
            Console.WriteLine("2. Rozloučit se");
            if (AntiFall() == 2)
            {
                Console.WriteLine($"I tobě hezký zbytek dne {hero.name}. A šťastnou cestu.");
            }
            Console.WriteLine();


            Console.WriteLine("Od chaloupky pokračuješ dál a dostneš se k jezeru. Jezero by se dalo dobře využít k občestvení. Napiješ se a chceš si i ulovit rybu. Najednou se ale z vody vyboří muž v zeleném fraku a se zeleným cilindrem.");
            Npc npc7 = new Npc("Vašek", "střední", "Biologie", 2);
            Console.WriteLine($"To ať tě ani nenapadne! Na moje ryby mi nesahej! Já jsem {npc7.name} a jsem místním vodníkem. Teď dostaneš otázku a za tvou troufalost bude {npc7.difficulty} a bude z oblasti {npc7.topic}.");
            if (npc7.AskWithOptions("Jaká je největší původní česká ryba?", 2, "Štika", "Sumec", "Úhoř") == 1)
            {
                hero.kp += npc7.points;
                npc7.correct = true;
            }
            else
            {
                hero.kp -= npc7.points;
            }
            Console.WriteLine();


            Console.WriteLine("Tohle teda nebyl moc příjemný člověk, že. Teda spíš ne moc příjemný vodník. Pomalu se tě začínají zmocňovat myšlenky, že ta cesta možná opravdu nebude tak jednoduchá a krásná. Ale tvá odvaha tě neopouští a pokračuješ od rybníka dál. Cesta vede kolem podivných soch. Ty, jakmile kolem nich procházíš, ožívají a zastavují tě v tvé cestě.");
            Npc npc8 = new Npc("Alfréd", "lehká", "historie", 1);
            Npc npc9 = new Npc("Přemysl", "lehká", "historie", 1);
            Console.WriteLine($"Nepospíchej tak {hero.name}. Máme pro tebe každý otázku.");
            Console.WriteLine("1. Tak se ptejte, pospíchám.");
            Console.WriteLine("2. A kdo jste, že tu stojíte jak sochy?");
            if (AntiFall() == 2)
            {
                Console.WriteLine($"My totiž opravdu jsme sochy. Dříve tomu tak nebylo, to jsme ještě byli normálními lidmi. Ale před mnoha staletími jsme zkoušeli tuto cestu a neuspěli. Byli jsme zakleti a musime pokládat otázky. Mimochodem já jsem {npc8.name} a toto je můj přítel {npc9.name}. Protože jsme tak staří, tak se tě zeptáme na něco z {npc8.topic}. Ale neboj, do našich kamenných hlav se moc infomací nevejde, takže otázka bude {npc8.difficulty}");
            }
            if (npc8.Ask("V jakém roce skončila 2. světová válka", "1945") == 1)
            {
                hero.kp += npc8.points;
                npc8.correct = true;
            }
            else
            {
                hero.kp -= npc8.points;
            }
            if (npc9.Ask("Kdy vstoupila Česká republika do EU", "2004") == 1)
            {
                hero.kp += npc9.points;
                npc9.correct = true;
            }
            else
            {
                hero.kp -= npc9.points;
            }
            Console.WriteLine();


            Console.WriteLine("Naštěstí byli tihle pánové narozdíl od vodníka přijemní. Cesta vede pořád dál a tak jdeš po ní. Zavede tě opět z lesa ven na ne příliš vysoký kopec. Na kopci je hrad. Tedy spíš býval, protože z něj zbyly už jen trosky. Chceš se podívat po okolí a tak vylezeš na polorozpadlou věž. Okolo kopce jsou samé lesy kam jen oko dohlédne. Což ti přijde trochu divné, protože tak dlouho ještě nejdeš, aby vesnice, z které jsi vycházel nebyla vidět. Taky si uvědomíš, že se vůbec neposunulo slunce i když jsi na cestě uz nekolik hodin. Tato cesta je opravdu magická. Z podlahy věže se vynoří duch.");
            Npc npc10 = new Npc("Bartoloměj", "střední", "astronomie", 2);
            Console.WriteLine("1. Fuj to jsem se lekl. Co ode mne chceš?");
            Console.WriteLine("2. To jsem mohl čekat, že se tu někdo takový objevý. Kdopak jsi?");
            if (AntiFall() == 1)
            {
                Console.WriteLine($"Já jsem {npc10.name} a jako každý na téhle cestě ti položím {npc10.difficulty} otázku z {npc10.topic}.");
            }
            else
            {
                Console.WriteLine($"Zdravím já jsem býval před mnoha lety astronomem zdejšího krále. Byl jsem tu ale zavražděn svým konkurentem a teď tu žiju mezi světy živých a mrtvých. Málem jsem zapomněl. Jsem {npc10.name} a položím ti {npc10.difficulty} otázku z {npc10.topic}.");
            }
            if (npc10.AskWithOptions("Jaké je největší souhvězdí podle plochy na nebi?", 1, "Hydra", "Velký vůz", "Orion") == 1)
            {
                hero.kp += npc10.points;
                npc10.correct = true;
            }
            else
            {
                hero.kp -= npc10.points;
            }
            Console.WriteLine();


            Npc npc11 = new Npc("Bezejmenný", "těžká", "jazyky", 3);
            Console.WriteLine("Od zříceniny vede cesta opět zpátky do lesa. Tentokrát je les však hustší a postupně v něm ubývá světla. Ubyde ho natolik, že ve tmě sotva vidíš na cestu, aby ses neztratil. Nekoukás před sebe a do něčeho narazíš.");
            Console.WriteLine("Dávej pozor kam jdeš člověče! To se snad dělá, narážet do ostatních?");
            Console.WriteLine("1. Tak snad se zas tolik nestalo.");
            Console.WriteLine("2. Pardón, v té tmě je tak špatně vidět, že jsem si vás ani nevšiml");
            if (AntiFall() == 1)
            {
                Console.WriteLine("Měl by ses nad sebou zamyslet. Náš pán tě za takové chování potrestá a to opravdu nechceš.");
            }
            else
            {
                Console.WriteLine("V pořádku. Zas tolik se nestalo.");
            }
            Console.WriteLine("1. Určitě mi Taky chcete položit hádanku, tak se ptejte.");
            Console.WriteLine("2. A kdo vlasně jste?");
            if (AntiFall() == 1)
            {
                Console.WriteLine($"To máš pravu. Má otázka bude z tématu {npc11.topic} a bude {npc11.difficulty}.");
            }
            else
            {
                Console.WriteLine($"Já jsem {npc11.name}. Jsem v téhle tmě už tak dlouho, že si nepamatuju jak se jmenuji, jak vypadám a kdo jsem. Proto ti rychle položím otázku, aby tě nestihl stejný osud. Bude to {npc11.difficulty} otázka z tématu {npc11.topic}");
            }
            if (npc11.AskWithOptions("Jak se německy řekne krabička sirek?", 3, "Vergnügungspark", "Sirkenbox", "Streichholzschachtel") == 1)
            {
                hero.kp += npc11.points;
                npc11.correct = true;
            }
            else
            {
                hero.kp -= npc11.points;
            }
            Console.WriteLine();



            Npc npc12 = new Npc("Smrt", "těžká", "strach", 3);
            Console.WriteLine("Rychle postupuješ dál a tma pomalu opadá. Místo ní teď přichází mlha. Z ní se pomalu noří hřbitov. Cesta vede skrz něj a tak ti nezbývá nic jiného, než do něj vejít. U největší hrobky na tebe čeká postava s kosou.");
            Console.WriteLine($"Nemusíš se mě bát. Jsem sice {npc12.name}, ale zatím jsem si pro tebe nepřišla. Pouze ti položím otázku a ještě ti něco povím. Bude to tvá snad předposlední otázka. Bude {npc12.difficulty} a z tématu mně nejbližšímu: {npc12.topic}. Ale neboj není na ní špatná odpověď, pouze se budeš muset podívat do svého srdce.");
            Console.ReadLine();
            hero.kp += npc12.points;
            if (hero.kp < 13)
            {
                Console.WriteLine("Zajímavá odpověď. Bohužel se podle tvých odpovědí ukázalo, že nepatříš k těm nejbystřejším. Proto ti dám možnost si zopakovat ty špatné a pokud se dostatečně napravíš, můžes pokračovat k našemu pánu. Jinak pro tebe cesta končí.");
                Console.WriteLine();
                if (npc1.correct == false)                              
                {
                    if (npc1.AskWithOptions("Jaké je první písmeno abecedy?", 3, "d", "t", "a") == 1)         
                    {
                        hero.kp += 2*npc1.points;                         //tohle není úplně ideální postup, ale lepši se mi nepodařilo vymyslet
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc1.points;
                        Console.WriteLine();
                    }
                }
                if (npc2.correct == false)
                {
                    if (npc2.Ask("Kolik má USA států?", "50") == 1)
                    {
                        hero.kp += 2 * npc2.points;
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc2.points;
                        Console.WriteLine();
                    }
                }
                if (npc3.correct == false)
                {
                    if (npc3.Ask("Kolik celých kilometrů má maraton?", "42") == 1)
                    {
                        hero.kp += 2*npc3.points;
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc3.points;
                        Console.WriteLine();
                    }
                }
                if (npc4.correct == false)
                {
                    if (npc4.AskWithOptions("O jakém tvaru jsou Euklidovy věty?", 2, "Kruh", "Trojúhelník", "Lichoběžník") == 1)
                    {
                        hero.kp += 2*npc4.points;
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc4.points;
                        Console.WriteLine();
                    }
                }
                if (npc5.correct == false)
                {
                    if (npc5.AskWithOptions("Jaká dynastie vládla na českém trůně po Přemyslovcích", 3, "Habsburkové", "Jagellonci", "Lucemburkové") == 1)
                    {
                        hero.kp += 2 * npc5.points;
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc5.points;
                        Console.WriteLine();
                    }
                }
                if (npc6.correct == false)
                {
                    if (npc6.AskWithOptions("Co je babské ucho?", 1, "Šalvěj", "Choroš", "Pampeliška") == 1)
                    {
                        hero.kp += 2*npc6.points;
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc6.points;
                        Console.WriteLine();
                    }
                }
                if (npc7.correct == false)
                {
                    if (npc7.AskWithOptions("Jaká je největší původní česká ryba?", 2, "Štika", "Sumec", "Úhoř") == 1)
                    {
                        hero.kp += 2 * npc7.points;
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc7.points;
                        Console.WriteLine();
                    }
                }
                if (npc8.correct == false)
                {
                    if (npc8.Ask("V jakém roce skončila 2. světová válka", "1945") == 1)
                    {
                        hero.kp += 2*npc8.points;
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc8.points;
                        Console.WriteLine();
                    }
                }
                if (npc9.correct == false)
                {
                    if (npc9.Ask("Kdy vstoupila Česká republika do EU", "2004") == 1)
                    {
                        hero.kp += 2 * npc9.points;
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc9.points;
                        Console.WriteLine();
                    }
                }
                if (npc10.correct == false)
                {
                    if (npc10.AskWithOptions("Jaké je největší souhvězdí podle plochy na nebi?", 1, "Hydra", "Velký vůz", "Orion") == 1)
                    {
                        hero.kp += 2*npc10.points;
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc10.points;
                        Console.WriteLine();
                    }
                }
                if (npc11.correct == false)
                {
                    if (npc11.AskWithOptions("Jak se německy řekne krabička sirek?", 3, "Vergnügungspark", "Sirkenbox", "Streichholzschachtel") == 1)
                    {
                        hero.kp += 2 * npc11.points;
                        Console.WriteLine();
                    }
                    else
                    {
                        hero.kp -= npc11.points;
                        Console.WriteLine();
                    }
                }
                if (hero.kp < 13)
                {
                    Console.WriteLine("Bojužel ses moc nepolepšil. Je vidět, že ti na moudrosti nezáleží a ze svých chyb ses nepoučil. Proto pro tebe tady cesta končí.");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    Console.WriteLine("Výborně, polepšil ses. Za to si zasloužít dojít k našemu pánu.");
                }
            }
            else
            {
                Console.WriteLine($"Zajímavá odpověď. Před tebou stojí už jen poslední otázka. A to přímo od našeho pána. Na plácku, na který teď dojdeš se ti zjeví v jedné z jeho tří forem. Musíš správně odpovědět na jeho otázku nebo přijde můj čas a postarám se o tebe já {npc12.name}.");
            }
            Console.WriteLine();
            Boss boss1 = new Boss("Ábel", "robot", "matematika");
            Boss boss2 = new Boss("Ábel", "drak", "politika");
            Boss boss3 = new Boss("Ábel", "čert", "sport");
            Random rnd = new Random();
            int boss = rnd.Next(3);
            if (boss == 0)
            {
                Console.WriteLine($"Zdravím já jsem {boss1.name} a jsem pánem všeho. Jak vidíš, zjevil jsem se ti jako {boss1.form}. Má otázka bude z okruhu {boss1.topic}. Jsem velmi zaneprázdněn, tak jdeme hned na to.");
                if (boss1.AskWithOptions("Jaká je derivace sin(x)?", 3, "-sin(x)", "-cos(x)", "cos(x)") == 0)
                {
                    Console.WriteLine("Bohužel, pokus to byl dobrý, ale na slávu to nestačí. Teď už patříš do říše Smrti. Užívej svých věčných strastí a sbohem.");
                    Console.ReadKey();
                    return;
                }
            }
            else if (boss == 1)
            {
                Console.WriteLine($"Zdravím já jsem {boss2.name} a jsem pánem všeho. Jak vidíš, zjevil jsem se ti jako {boss2.form}. Má otázka bude z okruhu {boss2.topic}. Jsem velmi zaneprázdněn, tak jdeme hned na to.");
                if (boss2.AskWithOptions("Kdo byl poslední český komunistický prezident?", 1, "Gustav Husák", "Klement Gottwald", "Ludvík Svoboda") == 0)
                {
                    Console.WriteLine("Bohužel, pokus to byl dobrý, ale na slávu to nestačí. Teď už patříš do říše Smrti. Užívej svých věčných strastí a sbohem.");
                    Console.WriteLine();
                    Console.WriteLine("KONEC");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine($"Zdravím já jsem {boss3.name} a jsem pánem všeho. Jak vidíš, zjevil jsem se ti jako {boss3.form}. Má otázka bude z okruhu {boss3.topic}. Jsem velmi zaneprázdněn, tak jdeme hned na to.");
                if (boss3.AskWithOptions("Kdy se konaly první moderní olympijské hry?", 2, "1923", "1896", "2000") == 0)
                {
                    Console.WriteLine("Bohužel, pokus to byl dobrý, ale na slávu to nestačí. Teď už patříš do říše Smrti. Užívej svých věčných strastí a sbohem.");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Výborně, nečekal jsem, že se někomu někdy opravdu podaří dokončit tuto cestu. Teď jsi získal svou věčnou slávu a každý kdo tě potká bude vědět, že ty jsi ten nejchytřejší. Užívej života a sbohem.");
            Console.WriteLine();
            Console.WriteLine("KONEC");




            Console.ReadKey();
        }
    }
}
