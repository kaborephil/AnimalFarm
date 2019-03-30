using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Pig : Animal
    {
        //Polymorphism
        public override void Speak()
        {
            Console.WriteLine("Hello, my name is " + AnimalName + " and I am a pig. I say oink.");
        }

        public override void Eat()
        {
            Console.WriteLine("Pigs Eat anything!");
        }

        public override void Product()
        {
            Console.WriteLine("Pigs provide Pork");
        }
    }
}
