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
            Console.WriteLine("سگ در حال دویدن");
        }
        public void Eat()
        {
            Console.WriteLine("سگ استخوان میخورد ");
        }
        public void Sleep()
        {
            Console.WriteLine("توله سگ ها به خواب بیشتری نساز دارند");
        }
        public void MakeSound()
        {
            Console.WriteLine("سگ می گوید :واق واق ");
        }
    }
}

 
