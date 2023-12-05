using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class Program
    {
        class Human
        {
            private int age;                 //přístupový modifikátor - private (výchoze), public, protected
            public int height;                       //private - nejsou vidě zvenku
            public int weight;                        //public - je vidět odevšaď
            public string hairColor;                 //protected - něco mezi, je vidět jen ve třídách který z tý třídy něco dědí       
            public string eyeColor;
            public string name;

            public Human(int incomingage, int height, int weight)
            {
                age = incomingage;                                                  //možnosti vypořádání se se stejnojmennými proměnými
                this.height /*ta v tomhle konstriktoru*/ = height/*třídy*/;

                hairColor = "Neznámá";
                eyeColor = "Neznámá";
                name = "Neznámé";
            }
            public Human(int incomingage, int height, int weight, string hairColor, string eyeColor, string name)
            {
                age = incomingage;
                this.height  = height;
                this.weight = weight ;
                this.hairColor = hairColor ;
                this.eyeColor = eyeColor ;
                this.name = name ;

            }

            public void PrintCharakteristics()
            {
                string printedName = name;
                if (printedName == null)
                {
                    printedName = "Bezejmenný člověk";
                }
                Console.WriteLine($"{printedName} je starý/á {age} a měří {height}");
            }

            public float BMI()
            {
                float heightcalculation = height / 100f;
                float bmi = weight / (heightcalculation * heightcalculation);
                return bmi;
            }
            public int GetAge()             //abycho obešl private
            {
                return age;
            }
            public void SetAge(int age)       //abychom si to mohli ošetřit
            {
                if (age < 0 || age > 120)
                {
                    Console.WriteLine("Tento věk nejde zadat");
                }
                else
                {
                    this.age = age;
                }
                
            }
            public void SetAge(string age)
            {
                 bool isNumber = int.TryParse(age, out int ageNumber);
                if (isNumber)
                {
                    SetAge(ageNumber);
                    Console.WriteLine($"Věk člověka {name} změněn na {this.age}");
                }
                else
                {
                    Console.WriteLine("zdej číslo");
                }
            }
        }

        static void Main(string[] args)
        {
            Human human1 = new Human(32, 165, 65);

            human1 .PrintCharakteristics();

            Human human2 = new Human(18, 205, 90, "Brown", "Blue", "Lojza");

            human2.PrintCharakteristics();

            float bmi = human2.BMI();
            Console.WriteLine($"{human2.name} má BMI {bmi}");
            Human human3 = new Human(10, 130, 80);
            Console.WriteLine($"Díťě má BMI {human3.BMI()}");

            Console.WriteLine(human1.GetAge());

            human2.SetAge(50);
            Console.WriteLine(human2.GetAge());

            human1.SetAge(300);

            human1.SetAge("20");
            human1.PrintCharakteristics() ;
            human1.SetAge("dshtsdgf");
            human1.PrintCharakteristics();

            Console.ReadKey();
        }
    }
}
