using System;

namespace Constructor
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
