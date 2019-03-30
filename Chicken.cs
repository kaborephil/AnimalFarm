using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Chicken : Animal
    {
        //polymorphism
        public override void Speak()
        {
            Console.WriteLine("Hello, my name is " + AnimalName + " and I am a chicken. I say cluck."); 
        }

        public override void Eat()
        {
            Console.WriteLine("Chicken Eat grain!");
        }

        public override void Product()
        {
            Console.WriteLine("Horse provide eggs");
        }
    }
}
