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
            string input;

            //Display Header
            Console.WriteLine();
            Console.WriteLine("********************************** WELCOME TO SOUTHEAST AMIMAL FARM ******************************************"+"\n\n");
            Console.WriteLine(" Instruction \n"+ " To visit each animal section type a keyword :");
            Console.WriteLine(" chicken\n"+" cow\n"+" horse\n"+" pig\n\n");

            //Add dictionary data structure to match the keyword with display section
            Dictionary<string, string> keyword = new Dictionary<string, string>();

            keyword.Add("chicken", "********************* WELCOME TO CHICKEN SECTION **************************");
            keyword.Add("cow", "*********************WELCOME TO COW SECTION ***************************");
            keyword.Add("horse", "********************* WELCOME TO HORSE SECTION **************************");
            keyword.Add("pig", "********************* WELCOME TO PIG SECTION **************************");

            //Convert the dictionary to IEnumerable collection
            var element = keyword.ToList();
         
            do
            {

            GoBack:
                Console.Write("Enter a keyword to visit a section of the farm or type 'quit' to exit : ");
                input = Console.ReadLine();
                Console.WriteLine("\n\n");

               
                if ((input == "chicken") && (element[0].Key == "chicken"))
                {
                    Console.WriteLine(element[0].Value);

                    //Add Margin between objects
                    Console.WriteLine("\n\n");

                    Animal chicken = new Chicken();

                    Console.Write("Enter animal name: ");
                    chicken.AnimalName = Console.ReadLine();

                    chicken.Speak();
                    chicken.Eat();
                    chicken.Product();

                }
                else if ((input == "cow") && (element[1].Key == "cow"))
                {
                    Console.WriteLine(element[1].Value);

                    //Add Margin between objects
                    Console.WriteLine("\n\n");

                    Animal cow = new Cow();

                    Console.Write("Enter animal name: ");
                    cow.AnimalName = Console.ReadLine();

                    cow.Speak();
                    cow.Eat();
                    cow.Product();

                }
                else if ((input == "horse") && (element[2].Key == "horse"))
                {
                    Console.WriteLine(element[2].Value);

                    //Add Margin between objects
                    Console.WriteLine("\n\n");

                    Animal horse = new Horse();

                    Console.Write("Enter animal name: ");
                    horse.AnimalName = Console.ReadLine();

                    horse.Speak();
                    horse.Eat();
                    horse.Product();

                }
                else if ((input == "pig") && (element[3].Key == "pig"))
                {
                    Console.WriteLine(element[3].Value);

                    //Add Margin between objects
                    Console.WriteLine("\n\n");

                    Animal pig = new Pig();

                    Console.Write("Enter animal name: ");
                    pig.AnimalName = Console.ReadLine();

                    pig.Speak();
                    pig.Eat();
                    pig.Product();

                }
                else if (input == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Keyword! Try again!\n");
                    goto GoBack;

                }
            } while (input != "quit");
            Console.ReadKey();
           

        }
    }
}
