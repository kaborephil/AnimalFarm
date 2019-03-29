using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public class Horse : Animal
    {
        //implementing polymorphism
        public override void Speak()
        {
            Console.WriteLine("Hello, my name is " + AnimalName +" and Iam a horse. I say neigh.");
        }
    }
}
