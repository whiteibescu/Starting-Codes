using System;

namespace FloatingPoint
{
    class MainApp
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846f;  // float 형식 변수에 값을 직접 할당하려면 숫자 뒤에 f를 붙여줘야 합니다.
            Console.WriteLine(a);

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);            
        }
    }
}
