using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anima
{
    class Frog :  Animal
    {
        public void Walk()
        {
            Console.WriteLine("the frog jumps");
        }
        public void Eat()
        {
            Console.WriteLine("the frog eats insects");
        }
        public void Sleep()
        {
            Console.WriteLine("the frog sleep in the water");
        }
        public void MakeSound()
        {
            Console.WriteLine("the frog says :croak croak");
        }
    }
}

