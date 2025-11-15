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
            Console.WriteLine("قورباغه می پرد");
        }
        public void Eat()
        {
            Console.WriteLine(" قوباغه حشره میخورد");
        }
        public void Sleep()
        {
            Console.WriteLine("قورباغه در آب میخوابد");
        }
        public void MakeSound()
        {
            Console.WriteLine("قورباغه می گوید:قور قور");
        }
    }
}
