using System;
using System.Collections.Generic;

//Generic -> 일반화
//ex) lsit를 선언할 때 자료형으로 int,float, string등 다양한 자료형들이 대응이 된다.
//모든 자료형에대해 대응하는 생성자를 갖는 클래스를 만드는것은 비효율적이다.
//또한 기본 자료형이 아닌 내가 만든 새로운 클래스의 경우는 매번 추가해줘야한다
// -> <T>
//대안1. object 타입 -> 선언 후 다른 값에서 쓸 떼 타입 캐스팅을 해줘야한다.
//비슷한 기능 : var -> 차이점 : var는 우리가 자료형을 명시적으로 선언해주지 않아도
//컴파일러가 알아서 맞춰주는 것이다.

//object는 정말 object라는 자료형 타입이 되는것이다.
//object는 최상위 클래스이다 string이나 int는 모두 object를 상속 받는것이기
//때문에 object는 모든 자료형을 소화 할 수 있다.
//모든 자료형을 object로 사용하지 않는 이유 : object 자료형은 매우느리다

//int 같은 값들은 stack에 올라가는 복사 타입의 변수이다
//하지만 object는 힙에 올라가는 참조 타입으로만 사용 할 수 있다.
//즉 object a =3후 int n =(int)a 라는 구문을 사용하면
//내부적으로는 a를 만들 때 힙에 3을 저장하는 공간을 만든 후 a는 주소를 가르키며
//n에 할당 할 때 해당 주소 값을 참조하여 복사후 n에 넣어주는 연산을 거치게 된다.
//->박싱 언박싱 과정을 거친다.

//결론 대안1은 좋은 선택지가 아니다


//대안2. 일반화 형식 <T> : 템플릿 혹은 타입의 약자
//<T>로 선언된 클래스는 어떠한 자료형이 와도 대응을 해준다.
class MyGenericList<T> // 제네릭 클레스가 된다.
{
    T[] arr = new T[10]; // -> T는 추후 들어오는 자료형에 대응을 해주무르

}

class TestClass
{

}

class GenericTestClass<T> where T : struct //where문을 활용하여 조건을 넣을 수도 있다.
{
    //struct일 경우 어떤 값이든 상관없으나ㅣ T값은 값형식이어야한다.
    //where T : class -> 어떤 값이든 상관없으나 T값은 참조형식이어야할 때
    //where T : new() -> 클래스에 반드시 어떠한 인자도 받지 않는 기본 생성자가 있어야한다
    //where T : "className" -> 해당 클래스 혹은 클래스를 상속받는 형식이어야한다
}

//함수도 일반화가 가능하다
class MyGeneric
{
    void TestFunc<T>(T data)
    {
        Console.Write(data);
    }

    //인자가 여러개일 때
    void TestFuncMulti<T>(T data, T data2)
    {
        Console.Write(data);
        Console.Write(data2);
    }


    
    void SetGeneric()
    {
        //새로운 객체를 생성할 때마다 해당 자료형에 맞는 arr을 만들어 준다
        MyGenericList<int> a = new MyGenericList<int>();
        MyGenericList<float> b = new MyGenericList<float>();
        MyGenericList<string> c = new MyGenericList<string>();
        MyGenericList<TestClass> d = new MyGenericList<TestClass>();

        TestFunc<int>(3);
        TestFunc<float>(4.0f);
        TestFunc<string>("Hi");
    }

}