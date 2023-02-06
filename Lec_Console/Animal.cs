namespace Lec_Console
{
    abstract class Animal
    {
        public Animal()
        {
        }
        public string name = "-Без клички-";
        
        public virtual void Eat()
        {
            System.Console.WriteLine($"\tЖивотное {name} кушает"); 
        }

        public virtual void Move()
        {
            System.Console.WriteLine("\tЖивотное перемещается");
        }

    }

    class Cat: Animal
    {
        public Cat(string name) { this.name = name; }
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
        public Dog(string name) { this.name = name; }

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

}
