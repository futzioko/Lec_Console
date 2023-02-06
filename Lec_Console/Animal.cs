namespace Lec_Console
{
    abstract class Animal
    {
        public Animal()
        {
        }
        public string name = "-Без клички-";
        public string kind;

        public abstract void Eat();
        public abstract void Move();

    }

    class Cat: Animal
    {
        public Cat(string name) { this.name = name;
                                  kind = "Кошка";
        }
        public override void Eat()
        {
            System.Console.WriteLine($"\tКошка {name} кушает Whiskas 15 лет и не жалуется");
        }

        public override void Move()
        {
            System.Console.WriteLine("\tКошка аккуратно перемещается на 4-х лапах");
        }
    }


    class Dog: Animal
    {
        public Dog(string name) { this.name = name; 
                                  kind = "Собака"; }

        public override void Eat()
        {
            System.Console.WriteLine($"\tВерный пёс {name} сейчас съест ... \n \t\t\t ...Мусю");
        }

        public override void Move()
        {
            System.Console.WriteLine($"\t{name} перемещается на 4-х лапах,\n" +
                                     $"\t\t но будь осторожен, он снесет все на своем пути");
        }
    }

    class Bear : Animal
    {
        public Bear(string name) { this.name = name; 
                                   kind = "Медведь"; }
        public override void Eat()
        {
            System.Console.WriteLine($"Мишка {name} кушает ягодки");
        }

        public override void Move()
        {
            System.Console.WriteLine("Мишка идет на задних лапках");
        }
    }

}
