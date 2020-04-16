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
        public override void SealMe()  //주석 참고
        {
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
        }
    }
/*이 예제 코드의 실행 결과는 없습니다. 컴파일 에러가 납니다. 봉인 메소드는 파생 클래스의 작성자를 위한 기반 클래스 작성자의 배려입니다. 혹시라도 파생 클래스의 작성자가 기반 클래스로부터 상속받은 메소드 하나를 오버라이등했는데
이 때문에 클래스로부터 상속받은 메소드 하나를 오버라이딩했는데 이 때문에 클래스의 다른 부분들이 오작동을 하게 된다고 생각해보세요. 파생 클래스의 작성자는 자신이 작성한 코드만으로는 객체가 원하는대로 동작하지 않는 원인을 알길이
없습니다. 오작동을 할 위험이 있거나 잘 못 오버라이당함으로써 발생할 수 있는 문제가 예상된다면, 이렇게 봉인 메소드를 이용해서 상속을 사전에 막는 것이 낫습니다. 컴파일할 때 에러가 나므로 파생 클래스의 작성자는 코드가 제품으로
출시되기 전에 문제를 파악할 수 있습니다. */