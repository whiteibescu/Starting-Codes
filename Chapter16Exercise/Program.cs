//1. 다음 코드 중에서 올바로 동작하지 않는 것을 고르세요.

using System;

Type t = myObject.GetType();
Type t = typeof( "int" );  //작동 안됨
Type t = Type.GetType(int);
Type t = Type.GetType("System.Int32");


// 2.애트리뷰트와 주석의 차이는 무엇입니까?
//주석은 사용자가 쓰고 읽는 정보 ex 메모
//애트리뷰트는 사용자가 쓰고 컴퓨터가 읽는다.