using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu.
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem kamen-nuzky-papir.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy skore obou
             *
             * Opakuj tolikrat, kolik kol chces hrat:
             * {
             *      Dokud uzivatel nezada vstup spravne:
             *      {
             *          - nacitej vstup od uzivatele
             *      }
             *      
             *      - vygeneruj s pomoci rng.Next() nahodny vstup pocitace
             *      
             *      Pokud vyhral uzivatel:
             *      {
             *          - informuj uzivatele, ze vyhral kolo
             *          - zvys skore uzivateli o 1
             *      }
             *      Pokud vyhral pocitac:
             *      {
             *          - informuj uzivatele, ze prohral kolo
             *          - zvys skore pocitaci o 1
             *      }
             *      Pokud byla remiza:
             *      {
             *          - informuj uzivatele, ze doslo k remize
             *      }
             * }
             * 
             * - informuj uzivatele, jake mel skore on/a a pocitac a kdo vyhral.
             */

            int sp = 0;
            int sh = 0;
            Random rng = new Random(); //instance tridy Random pro generovani nahodnych cisel
            for (int i=0;  i < 10; i++)
            {
                Console.WriteLine("kámen, nůžky, papír");
                string hrac = Console.ReadLine();
               int pocitac = rng.Next(1,4);         //1=kamen, 2=nuzky, 3=papir
                if (hrac == "kámen")
                {
                    if (pocitac == 1)
                    {
                        Console.WriteLine("remíza");
                    }
                    else if (pocitac == 2)
                    {
                        Console.WriteLine("výhra");
                        sh++;
                    }
                    else
                    {
                        sp++;
                        Console.WriteLine("prohra");
                    }
                }
                if (hrac == "nůžky")
                {
                    if (pocitac == 1)
                    {
                        sp++;
                        Console.WriteLine("prohra");
                    }
                    else if (pocitac == 2)
                    {
                        Console.WriteLine("remíza");
                    }
                    else 
                    {
                        sh++;
                        Console.WriteLine("výhra");
                    }
                }
                if (hrac == "papir")
                {
                    if (pocitac == 1)
                    {
                        sh++;
                        Console.WriteLine("výhra");
                    }
                    else if(pocitac == 2)
                    {
                        sp++;
                        Console.WriteLine("prohra");
                    }
                    else
                    {
                        Console.WriteLine("remíza");
                    }
                }
            }
            if (sh > sp)
            {
                Console.WriteLine("vyhrál jsi");
            }
            else if (sp > sh)
            {
                Console.WriteLine("prohrál jsi");
            }
            else
            {
                Console.WriteLine("remíza");
            }
            Console.ReadKey(); //Aby se nam to hnedka neukoncilo
        }
    }
}
