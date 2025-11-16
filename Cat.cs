using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anima
{
    class Cat :Animal
    {
        public void Walk()
        {
            Console.WriteLine("teh cat walks slowly");
        }
        public void Eat()
        {
            Console.WriteLine("the cat eats cooked meat");
        }
        public void Sleep()
        {
            Console.WriteLine("the cat sleeps in a soft place");
        }
        public void MakeSound()
        {
            Console.WriteLine("cat says :meow meow");
        }
    }
}

  

