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
            Console.WriteLine("گربه به آرامی راه می رود");
        }
        public void Eat()
        {
            Console.WriteLine("گربه گوشت پخته میخورد");
        }
        public void Sleep()
        {
            Console.WriteLine("گربه حای نرم میخوابد");
        }
        public void MakeSound()
        {
            Console.WriteLine("گربه می گوید : میو میو");
        }
    }
}

  
