using System;

namespace DerivedFromArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 30, 20, 7, 1 };
            Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Base type of array : {array.GetType().BaseType}");
        }
    }
}
