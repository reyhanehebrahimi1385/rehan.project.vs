using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anima
{
    class Crow :Animal
    {
        public void Walk()
        {
            Console.WriteLine("crows fly");
        }
        public void Eat()
        {
            Console.WriteLine("crows eat insects and carrion");
        }
        public void Sleep()
        {
            Console.WriteLine("the sleep in a cavity");
        }
        public void MakeSound()
        {
            Console.WriteLine("the crow says: caw caw");
        }
    }
}


