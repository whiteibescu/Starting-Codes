/*
  

1. 다음 코드의 출력값은 얼마일까요?
Func<int> func_1= () => 10;
Func<int, int> fucn_2 = (a) => a * 2;

Console.WriteLine(func_1() + func_2(30));

2.다음 코드에서 익명 메소드를 람다식으로 수정하세요.


using System;

namespace Chapter14Exercise
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            foreach (int a in array)
            {
                Action aciton = new Action
                (
                    delegate ()
                    {
                        Console.WriteLine(a * a);
                    }
                    );
            }    aciton.Invoke();
        }
    }
}
*/