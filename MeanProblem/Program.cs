using System;

namespace MeanProblem
{
    class Program
    {
        public static void Main()
        {
            double mean = 0;

            Mean( 1, 2, 3, 4, 5, mean);

            Console.WriteLine("평균 : {0}", mean);
        }

        public static void Mean(
            double a, double b, double c,
            double d, double e, double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
// 다음의 코드에서 Mean() 메소드를 실행한 후의 mean은 얼마의 값을 가질까요? 3이라고요? 아닙니다. 0입니다. 자, 문제나갑니다. 
// mean이 0을 갖게 되는 원인과 이를 바로잡으려면 다음의 코드에서 어떤 부분을 고쳐야 할까요?