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
            Console.WriteLine("کلاغ ها میپرند");
        }
        public void Eat()
        {
            Console.WriteLine("کلاغ ها حشرات و گوشت لاشه میخورند");
        }
        public void Sleep()
        {
            Console.WriteLine("در حفره ها میخوابند");
        }
        public void MakeSound()
        {
            Console.WriteLine("کلاغ می گوید: قار قار");
        }
    }
}

