using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int averageMaxAge;
            public int endangerement;
            public void AnimalNoise()
            {
                Console.WriteLine("animal noise");
            }
        }
        class Dog : Animal
        {
            public int numberOfPuppies;
            public string race;
            public void Bark()
            {
                Console.WriteLine("Woof Woof!");
            }
        }
        
        class Cat : Animal
        {
            public bool lovesMilk;
            public string furColour;
            public void Meow()
            {
                Console.WriteLine("Meow Meow!");
            }
        }
        static void Main(string[] args)
        {
            Dog newDog = new Dog();
            newDog.name = "Fido";
            newDog.race = "Bullterier";
            newDog.AnimalNoise();
            Console.WriteLine($"{newDog.name}, {newDog.race}");

            Cat newCat = new Cat();
            newCat.name = "Micka";
            newCat.lovesMilk = true;
            newCat.furColour = "ginger";
            Console.WriteLine($"{newCat.name}, {newCat.lovesMilk}, {newCat.furColour}");

            newDog.Bark();
            newCat.Meow();

            Console.ReadKey();
        }
    }
}
