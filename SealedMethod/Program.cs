using System;

    class Base
    {
        public virtual void SealMe()
        {
        }
    }

    class Derived : Base {
        public sealed override void SealMe()
        {
        }
    }

    class WantToOverride : Derived
    {
        public override void SealMe()
        {
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
        }
    }
//이 예제 코드의 실행 결과는 없습니다. 컴파일 에러가 납니다.