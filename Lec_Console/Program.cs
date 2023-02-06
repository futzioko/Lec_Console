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

            Console.WriteLine("\n");

            Dog dog = new Dog("Шарик");
            dog.Eat();
            dog.Move();

            Console.WriteLine("\n");

            Animal cat1 = new Cat("Зюзя");
            Animal dog1 = new Dog("Гав");
            cat1.Eat();
            cat1.Move();
            dog1.Eat();
            dog1.Move();


            Console.ReadKey();
        }
    }
}
