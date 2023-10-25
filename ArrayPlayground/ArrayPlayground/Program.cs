using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] myArray = {10,20,30,40,50};

            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            Console.WriteLine("pomocí for");
            for (int i = 0; i < myArray.Length-1; i++)    //vylepšení: místo 5 dát myArray.Lenght
            {
                Console.WriteLine(myArray[i] + myArray[i+1]);
            }
            Console.WriteLine("pomocí foreach");
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            for (int i = 0;i < myArray.Length;i++)
            {
                sum = sum + myArray[i];     //nebo sum += myArray[i];  existuje taky -=, *=, /=
            }
            Console.WriteLine($"součet prvků je {sum}");
            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = 0;
            average = sum / myArray.Length;
            Console.WriteLine($"průměr prvků je {average}");
            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = int.MinValue;
            //max = myArray.Max();
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            Console.WriteLine($"maximum v poli je {max}");
            
            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = int.MaxValue;         //potřebuju začínat s velkým číslem, aby mi to pak nebralo to číslo jako minimum
            for (int i = 0; i < myArray.Length ; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
            }
            //min = myArray.Min();
            Console.WriteLine($"minimum v poli je {min}");
            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int index = 0;
            Console.WriteLine("co  chceš najít?");
            int usernumber = int.Parse(Console.ReadLine());
            bool foundnumber = false;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == usernumber)
                {
                    foundnumber = true;
                    Console.WriteLine($"{usernumber} je {i}. prvek");
                    break;      //aby to neprocházelo dál, když už jsme číslo našli
                }
            }
            if (foundnumber == false)
            {
                Console.WriteLine($"hledané číslo {usernumber} v seznamu není");
            }
            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random rng = new Random();
            myArray = new int[100];
            for (int i = 0;i < myArray.Length; i++)
            {
                myArray[i] = rng.Next(0,10);
                Console.WriteLine($"číslo na indexu {i} je {myArray[i]}");
            }

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            foreach (int number in myArray)
            {
                counts[number]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine($"Číslo {i} se vyskytuje {counts[i]} krát");
            }


            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] mySecondArray = new int[100];
            for(int i = myArray.Length-1; i>=0 ; i--) //nebo (int i = 0; i < myArray.Lenght;i++) {mySecondArray[mySecondArray.Lenght - 1 - i] = myArray[i]} 
            {
                mySecondArray[i] = myArray[99-i];
            }
            Console.WriteLine("druhé pole");
            foreach (int number in mySecondArray)
            {
                Console.Write(number);
            }

            Console.ReadKey();
        }
    }
}
