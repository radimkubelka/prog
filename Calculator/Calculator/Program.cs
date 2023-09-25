using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pokud se budes chtit na neco zeptat a zrovna budu pomahat jinde, zkus se zeptat ChatGPT ;) - https://chat.openai.com/
             * 
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Mozna rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */



            //Chatgpt jsem použil na objevení možných funkcí. Např. funkce z class Math, o jejichž existenci jsem netušil

            double cislo1, cislo2;
            string operace;
            double vysledek = 0;
            Console.WriteLine("napiš první číslo");
            while (!double.TryParse(Console.ReadLine(), out cislo1))
            {
                Console.WriteLine("Zadej platné první číslo");
            }

            Console.WriteLine("zadej operaci (možnosti: +, -, *, /, ^, sqrt, log , log10, sin, cos, tan, cotg, abs, sin-1, cos-1, tan-1 ( sqrt, log, log10, sin, cos, tan, cotg, abs, sin-1, cos-1, tan-1 je jen z 1. čísla)");
            operace = Console.ReadLine();
            while (operace != "+" && operace != "-" && operace != "*" && operace != "/" && operace != "^" && operace != "sqrt" && operace != "log" && operace != "log10" && operace != "sin" && operace != "cos" && operace != "tan" && operace != "cotg" && operace != "abs" && operace != "sin-1" && operace != "cos-1" && operace != "tan-1")
            {
                Console.WriteLine("Zadej možnou operaci");
            }

            if (operace != "sqrt" && operace != "log" && operace != "log10" && operace != "sin" && operace != "cos" && operace != "tan" && operace != "cotg" && operace != "abs" && operace != "sin-1" && operace != "cos-1" && operace != "tan-1")
            {
                Console.WriteLine("napiš druhé číslo");
                while (!double.TryParse(Console.ReadLine(), out cislo2))
                {
                    Console.WriteLine("Zadej platné druhé číslo");
                }
            }
            else
            {
                cislo2 = 0;
            }

            //po sem načítání proměnných, odsud vlastní počítání

            if (operace == "+")
            {
                vysledek = cislo1 + cislo2;
            }
            else if (operace == "-")
            {
                vysledek = cislo1 - cislo2;
            }
            else if (operace == "/")
            {
                if (cislo2 == 0)
                {
                    vysledek = cislo1 / cislo2;
                }
                else
                {
                    Console.WriteLine("nulou nelze dělit");
                    Console.ReadKey();
                    return;
                }
            }
            else if (operace == "^")
            {
                vysledek = Math.Pow(cislo1,cislo2);
            }
            else if (operace == "sqrt")
            {
                vysledek = Math.Sqrt(cislo1);
            }
            else if (operace == "log")
            {
                vysledek = Math.Log(cislo1);
            }
            else if (operace == "log10")
            {
                vysledek = Math.Log10(cislo1);
            }
            else if (operace == "sin")
            {
                vysledek = Math.Sin(cislo1);
            }
            else if (operace == "cos")
            {
                vysledek = Math.Cos(cislo1);
            }
            else if (operace == "tan")
            {
                vysledek = Math.Tan(cislo1);
            }
            else if (operace == "cotg")
            {
                vysledek = 1/Math.Tan(cislo1);
            }
            else if (operace == "abs")
            {
                vysledek = Math.Abs(cislo1);
            }
            else if (operace == "sin-1")
            {
                vysledek = Math.Asin(cislo1);
            }
            else if (operace == "cos-1")
            {
                vysledek = Math.Acos(cislo1);
            }
            else if (operace == "tan-1")
            {
                vysledek = Math.Atan(cislo1);
            }
            else
            {
                vysledek = (cislo1 * cislo2);
            }
            
            //různé zapsání výsledků -> u něčeho není potřeba znát druhé číslo

            if (operace != "sqrt" && operace != "log" && operace != "log10" && operace != "sin" && operace != "cos" && operace != "tan" && operace != "cotg" && operace != "abs" && operace != "sin-1" && operace != "cos-1" && operace != "tan-1")
            {
                Console.WriteLine(cislo1 + " " + operace + " " + cislo2 + " = " + vysledek);
            }
            else
            {
                Console.WriteLine(operace +" "+ cislo1 + " = " + vysledek);
            }

            Console.ReadKey(); //Toto nech jako posledni radek, aby se program neukoncil ihned, ale cekal na stisk klavesy od uzivatele.


            // počítání pomocí swich
            /*switch (operace)
            {
                case "+":
                    vysledek = cislo1 + cislo2;
                    break;
                case "-":
                    vysledek = cislo1 - cislo2;
                    break;
                case "*":
                    vysledek = cislo1 * cislo2;
                    break;
                case "/":
                    if (cislo2 != 0)
                    {
                        vysledek = cislo1 / cislo2;
                    }
                    else
                    {
                        Console.WriteLine("nulou nelze dělit");
                        Console.ReadKey();
                        return;
                    }
                    break;
            }
            Console.WriteLine(cislo1 + " " + operace + " " + cislo2 + " = " + vysledek);*/


            //načtení hodnot bez opravování
            /*Console.WriteLine("napiš první číslo");
            string skorocislo1 = Console.ReadLine();
            double cislo1 = float.Parse(skorocislo1);
            Console.WriteLine("zadej operaci (možnosti: +, -, *, /)");
            string operace = Console.ReadLine();
            Console.WriteLine("napiš druhé číslo");
            string skorocislo2 = Console.ReadLine();
            float cislo2 = float.Parse(skorocislo2);
            float vysledek = 0;*/
        }
    }
}
