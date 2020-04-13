using System;

namespace Chapter2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            int area = int.Parse(width) * int.Parse(height);

            Console.WriteLine("사각형의 넓이:{0}", area);

            //이곳에 사각형의 넓이를 계산하고
            //출력하는 루틴을 추가하세요.
        }
    }
}
