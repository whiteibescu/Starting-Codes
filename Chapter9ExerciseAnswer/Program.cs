using System;
using static System.Console;
namespace Chapter9ExerciseAnswer
{
    class NameCard
    {
        public int age { get; set; }
        public string name { get; set; }
    }
    class MainApp
    {
        public static void Main()
        {
            NameCard namecard = new NameCard() { name = "상현", age = 24 };
            WriteLine("나이 : {0}", namecard.age);
            WriteLine("이름 : {0}", namecard.name);
        }
    }
}
