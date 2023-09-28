using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Deathroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu (lze udelat i rekurzi).
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem deathroll.
             * Pravidla deathrollu: Prvni hrac navrhne cislo (puvodne ve wowku pocet goldu, o ktere se hraci vsadi) a "rollne" navrhnute cislo, jinak receno je to stejne,
             * jako kdyby si hodil kostkou s tolika stenami, jako je navrhnute cislo. Prvnimu hraci "padne" nejake cislo a druhy hrac si "rollne" padnute cislo.
             * Prohrava ten hrac, kteremu padne 1 jako prvnimu.
             * Ukazka hry: Hraci se shodnou na cisle 1000. Prvni hrac rollne 0-1000, padne mu 920. Druhy hrac rolluje 0-920, padne mu 235 atd. atd. az jednomu z hracu padne 1
             * a ten prohrava.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy aktualne rollovane cislo a stav "goldu" uzivatele i pocitace (oba zacinaji treba s 1000 goldu)
             * 
             * - uzivatel zada prvotni sazku, ktera musi byt maximalne tolik, kolik ma goldu
             * 
             * Opakuj dokud nepadne jednomu z hracu 1:
             * {
             *      Pokud je sude kolo:
             *      {
             *          - uzivatel zada hodnotu, kterou rolluje
             *          - kontroluj, ze uzivatel zadal spravnou hodnotu
             *          - uloz rollnute cislo
             *          - vypis uzivateli, co rollnul
             *      }
             *      Pokud je liche kolo:
             *      {
             *          - pocitac rollne nahodne cislo mezi 0 a aktualne rollovanym cislem
             *          - vypis uzivateli, co rollnul pocitac
             *      }
             * }
             * 
             * 
             * - posledni hrajici hrac prohral, protoze mu padla 1 a sazku bere druhy hrac
             * - vypis uzivateli kdo vyhral a stav goldu uzivatele i pocitace
             * 
             * ROZSIRENI:
             * - umozni uzivateli opakovat deathroll dokud ma nejake goldy
             */


            int gu = 1000;
            int gp = 1000;      //now roll, goldy uzivatele, goldy pocitace
            int kolo = 0;
            Console.WriteLine("kolik chceš rollovat?");
            int nroll = int.Parse(Console.ReadLine());
            while (nroll > gu || nroll <1)
            {
                Console.WriteLine("můžeš jen od 1 do "+gu+", zkus to znovu");
                nroll = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            int bet = nroll;
            Random rng = new Random();

            for (int u = 0; gu > 0; u++)
            {
                for (int i = 1; ; i++)
                {
                    if (nroll == 1)
                    {
                        break;
                    }
                    else
                    {
                        if (i % 2 != 0)  //liché kolo = hráč
                        {
                            kolo += 1;
                            Console.WriteLine("kolo: " + kolo + ", hraje hráč od 1 do " + nroll);
                            nroll = rng.Next(1, nroll + 1);
                            Console.WriteLine("padlo " + nroll);
                            Console.WriteLine();
                        }
                        else             //sudé kolo = počítač
                        {
                            kolo += 1;
                            Console.WriteLine("kolo: " + kolo + ", hraje počítač od 1 do " + nroll);
                            nroll = rng.Next(1, nroll + 1);
                            Console.WriteLine("padlo " + nroll);
                            Console.WriteLine();
                        }
                    }

                }
                if (kolo % 2 == 0)
                {
                    Console.WriteLine("vyhrál jsi");
                    gu = gu + bet;
                    gp = gp - bet;
                }
                else
                {
                    Console.WriteLine("prohrál jsi");
                    gp = gp + bet;
                    gu = gu - bet;
                }

                Console.WriteLine("goldy hráče: " + gu + "  goldy počítače: " + gp);
                //rozšíření
                Console.WriteLine();
                if (gu > 0)
                {
                    Console.WriteLine("Chceš hrát znovu?");
                    string pokracovani = Console.ReadLine();
                    if (pokracovani != "ano")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("kolik chceš rollovat? (max " + gu + ")");
                        nroll = int.Parse(Console.ReadLine());
                        while (nroll > gu || nroll < 1)
                        {
                            Console.WriteLine("můžeš jen od 1 do " + gu + ", zkus to znovu");
                            nroll = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine();
                        bet = nroll;
                        kolo = 0;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("konec hry žebráku nebo zbabělče");

            Console.ReadKey();
        }
    }
}
