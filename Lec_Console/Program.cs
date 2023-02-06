using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            animal.Eat();
            animal.Move();
            
            Console.WriteLine("\n");

            Cat cat = new Cat("Муся");
            cat.Eat();
            cat.Move();

            Console.ReadKey();
        }
    }
}
