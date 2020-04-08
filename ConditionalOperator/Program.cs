using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result); // 아니 홀수가 되어야지 왜 짝수가 되는거지??????
        }
    }
}
