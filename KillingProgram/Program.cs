using System;

namespace KillingProgram
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i <5; i++)
            {
                Console.WriteLine(arr[i]); //i가 "배열의 크기가 -1"을 넘어서면 예외를 일으키고 종료. 이후의 코드들은 더 이상 실행하지 않음
            }
            Console.WriteLine("종료");
        }
    }
}
