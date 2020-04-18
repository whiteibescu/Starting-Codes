using System;
using static System.Console;
namespace Chapter5Exercise4
{
    class Program
    {
        public static void Main()
        {
            Write("반복 횟수를 입력하세요 :");
            int inPut = int.Parse(ReadLine());

            if (inPut <= 0)
                WriteLine("0보다 같거나 작은 숫자는 사용할 수 없습니다.");

            for(int i = 0; i < inPut; ++i)
            {
                for (int j = 0; j < i + 1; ++j)
                    Write("*");
                WriteLine();
            }    

        }

    }
}
// 4.다음과 같이 사용자로부터 입력받은 횟수만큼 별을 반복 출력하는 프로그램을 작성하세요. 
// 단, 입력받은 수가 0보다 작거나 같을 경우 "0보다 같거나 작은 숫자는 사용할 수 없습니다."라는 메시지를 띄우고 프로그램을 종료합니다.