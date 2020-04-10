using System;

namespace UsingOut
{
    class MainApp
    {
        static void Divide(int a, int b, out int quotient, out int remainder) 
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args) //다음은 out 키워드를 이용하여 Divide() 메소도를 호출하는 코드입니다.
        {
            int a = 20;
            int b = 3;
            // int c;
            // int d;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a}, b:{b}:, a/b:{c}, a%b:{d}");
        }
    }
}
