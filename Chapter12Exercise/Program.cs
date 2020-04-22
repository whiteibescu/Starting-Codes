/*
1.아래의 코드를 컴파일하면 다음과 같이 예외를 표시하고 비정상적으로 종료합니다. try~catch문을 이용해서 예외를 안전하게 잡아 처리하도록 코드를 수정하세요.
    0
    1
    2
    3
    4
    5
    6
    7
    7
    8
    9

    처리되지 않은 예외: System.IndexOutOfRangeException: 인덱스가 배열 범위를 벗어났습니다.
    위치 : EX12_1.MainApp.Main(string[] args) 파일 C:\Users\Sean\AppData\Local\TemporaryProjects\Ex12_1\Mainapp.cs:줄 9 */


using System;
using static System.Console;
using System.Collections;

namespace Chapter12Exercise
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            try
            {

                for (int i = 0; i < 10; i++)
                    arr[i] = i;

                for (int i = 0; i < 11; i++)
                WriteLine(arr[i]);
            }
            catch(Exception e)
            {
                WriteLine("예외발생, {0}", e.Message);
            }
            WriteLine("종료");
        }
    }
}
