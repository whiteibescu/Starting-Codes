using System;

namespace SwapExample2
{
    class Program
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
