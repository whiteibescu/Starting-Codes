using System;

namespace This
{
    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }

    class  MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh)");
            pooh.SetPostition("Waiter");
            Console.WriteLine($"{pooh.Getname()} {pooh.Position()}");

            Employee tigger = new Employee();
            tigger.Setname("Tigger");
            tigger.Setposition("Cleaner");
            Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
        }
    }
}
