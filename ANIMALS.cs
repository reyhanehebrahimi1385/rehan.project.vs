using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anima
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal frog = new Frog();
            Animal cat = new Cat();
            Animal dog = new Dog();
            Animal crow = new Crow();
            frog.MakeSound();
            frog.Eat();
            frog.Walk();
            frog.Sleep();

            Console.WriteLine("\n---FROG---");


            cat.MakeSound();
            cat.Eat();
            cat.Walk();
            cat.Sleep();

            Console.WriteLine("\n---CAT---");

            
            dog.MakeSound();
            dog.Eat();
            dog.Walk();
            dog.Sleep();
            Console.WriteLine("\n---DOG---");

            
            crow.MakeSound();
            crow.Eat();
            crow.Walk();
            crow.Sleep();
            Console.WriteLine("\n---CROW---");
            
          
    
    Console.ReadKey();
            


        }
    }
}
