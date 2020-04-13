using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result);
            
            // 조건식 ? 참일_떄의_값 : 거짓일_때의_값                                       
            //condition ? true : false                                      
            //ex) string result = a == 30 ? "삼십" : "삼십아님";
        }
    }
}
