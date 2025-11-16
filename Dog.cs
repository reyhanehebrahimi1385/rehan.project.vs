using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anima
{
    class Dog :Animal
    {
        public void Walk()
        {
            Console.WriteLine("the dog is running");
        }
        public void Eat()
        {
            Console.WriteLine("the dog easta bone ");
        }
        public void Sleep()
        {
            Console.WriteLine("puppies need more sleep");
        }
        public void MakeSound()
        {
            Console.WriteLine("the dog says :woof woof");
        }
    }
}

 

