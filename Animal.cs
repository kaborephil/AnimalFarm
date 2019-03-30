using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    public abstract class Animal
    {
        public string AnimalName { get; set; }

        public abstract void Speak();

        public abstract void Eat();

        public abstract void Product();
        
    }
}
