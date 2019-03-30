using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {

            //Display Header
            Console.WriteLine();
            Console.WriteLine("********************************** WELCOME TO SOUTHEAST AMIMAL FARM ******************************************"+"\n\n");
            Console.WriteLine(" Instruction \n"+ " To visit each animal section type a keyword :");
            Console.WriteLine(" chicken\n"+" cow\n"+" horse\n"+" pig\n\n");
            Animal chicken = new Chicken();

            Console.Write("Enter name: ");
            chicken.AnimalName = Console.ReadLine();

            chicken.Speak();
            chicken.Eat();
            chicken.Product();

            //Add Margin between objects
            Console.WriteLine("\n\n");

            Animal cow = new Cow();

            Console.Write("Enter name: ");
            cow.AnimalName = Console.ReadLine();

            cow.Speak();
            cow.Eat();
            cow.Product();

            //Add Margin between objects
            Console.WriteLine("\n\n");

            Animal pig = new Pig();

            Console.Write("Enter name: ");
            pig.AnimalName = Console.ReadLine();

            pig.Speak();
            pig.Eat();
            pig.Product();

            //Add Margin between objects
            Console.WriteLine("\n\n");

            Animal horse = new Horse();

            Console.Write("Enter name: ");
            horse.AnimalName = Console.ReadLine();

            horse.Speak();
            horse.Eat();
            horse.Product();

            Console.ReadKey();
           

        }
    }
}
