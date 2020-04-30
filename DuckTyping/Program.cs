using System;

namespace DuckTyping
{
    class Duck
    {
        public void Walk()
        { Console.WriteLine(this.GetType() + ".Walk"); }

        public void Swim()
        { Console.WriteLine(this.GetType() + ".Swim"); }

        public void Quack()
        { Console.WriteLine(this.GetType() + ".Quack"); }
    }

    class Mallard : Duck
    { }

    class Robot
    {
        public void Walk()
        { Console.WriteLine("Robot.Walk"); }

        public void Swim()
        { Console.WriteLine("Robot.Swim"); }

    }
}
