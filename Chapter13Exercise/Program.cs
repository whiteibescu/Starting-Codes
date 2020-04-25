/*1. 출력 결과가 다음과 같이 나오도록 아래의 코드에 익명 메소드를 추가하여 완성하세요.
7
2
*/


using System;

namespace Chapter13Exercise
{
    delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate Callback;

            Callback = 익명 메소드 선언

                Console.WriteLine(Callback(3, 4));
            
            Callback = 익명 메소드 선언

                Console.WriteLine(Callback(7, 5));
        }
    }
}

/* 2. 출력 결과가 다음과 같이 나오도록 다음 코드에 이벤트 처리기를 추가하세요.
축하합니다! 30번째 고객 이벤트에 당첨되셨습니다.
*/


using System;

namespace Ex13_2
{
    delegate void MyDelegate(int a);

    class Market
    {
        public event MyDelegate CustomerEvent;

        public void BuySomething( int CustomerNo )
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }

    class Mainapp
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDelegate(이벤트 처리기를 구현하세요. );

            for (int customerNo < 100; customerNo += 10)
                market.BuySomething(customerNo);

        }
    }
}
