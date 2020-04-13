using System;

namespace Constructor
{
    class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        ~Cat()
        {
            Console.WriteLine($"{Name}: 잘가");
        }

        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

        class MainApp
        {
            static void Main(string[] args)
            {
                Cat kitty = new Cat("키티", "하얀색");
                kitty.Meow();
                Console.WriteLine($"{kitty.Name} : {itty.Color}");

                Cat nero = new Cat("네로", "검은색");
                nero.Meow();
                Console.WriteLine($"{nero.Name} : {nero.Color}");
            }
        }        
}
//예제 프로그램의 결과가 다를 수도 있습니다.마지막 두줄은 매 실행 시마다 달라질 수 있습니다.