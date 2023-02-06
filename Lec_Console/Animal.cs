namespace Lec_Console
{
    class Animal
    {
        public string name;
        
        public void Eat()
        {
            System.Console.WriteLine("\tЖивотное кушает");
        }

        public void Move()
        {
            System.Console.WriteLine("\tЖивотное перемещается");
        }

    }

    class Cat: Animal
    {
        public Cat(string name) { this.name = name; }
        public void Eat()
        {
            System.Console.WriteLine($"\tКошка {name} кушает Whiskas 15 лет и не жалуется");
        }

        public void Move()
        {
            System.Console.WriteLine("\tКошка перемещается на 4-х лапах");
        }
    }

}
