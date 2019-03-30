using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Cow : Animal
    {
        //Polymorphism
        public override void Speak()
        {
            Console.WriteLine("Hello, my name is " + AnimalName + " and I am a cow. I say Moo.");
        }

        public override void Eat()
        {
            Console.WriteLine("Cows Eat grass!");
        }

        public override void Product()
        {
            Console.WriteLine("Cows provide beef");
        }
    }
}
