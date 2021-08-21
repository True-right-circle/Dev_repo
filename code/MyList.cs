using System;
using System.Collections.Generic; //List 사용을 위해
class MyList
{
    //배열은 선언시 크기를 정해줘야하며 이는 공간 부족이나 메모리 낭비로 이어질 수 있다.

    //List -> 배열과 달리 가변이 가능하다.
    //내부 구조는 동적 배열이다
    //선언시 크기를 정해줄 필요가 없다.
    public void MyListSet()
    {
        //list 선언<자료형>
        //참조형태이다.(new 선언이 필요하면 참조형으로 보면 된다.)
        List<int> mlist = new List<int>();

        //list 추가
        //마지막 인덱스 뒤에 1이 추가 된다 
        mlist.Add(1);

        //배열과 달리 insert, delete 기능이 제공된다.
        //배열은 직접 구현필요
        //Clear -> 전체 삭제
        //제공하는 함수를 통해 중간값을 삭제하거나 삽입하는것은 그리 효율적이지 않다
        //삽입의 경우 내부적으론 공간을 추가하여 생성하고 인덱스들의 위치를 바꾼 후
        //빈공간 또는 뒤로 밀린 공간에 값을 삽입하는 구조이기 때문에 내부적으로 많은 작업이 이뤄지는 것이다.
    
        //list의 단점 
        //ex 게임에서 100만마리의 몬스터를 list로 관리하고 있는중
        //특정 고유 ID를 갖는 몬스터를 찾고자 할 때 모두 순회를 하면서 찾으면 효율이 매우 
        //떨어질 것이다.

        //-> 해결하는 자료구조
        //특정 키를 가지고 해당 값을 찾는 자료구조 -> Dictionary
        //키와 값을 저장한다
        //<키, 값>
        //앞의 키값을 활용하여 해당 키가 갖는 값을 빠르게 찾을 수 있다.
        Dictionary<int, string> myDict = new Dictionary<int, string>();
        myDict.Add(1,"My value1");
        //또다른 값 선언 방법
        myDict[3] = "Set My value2";

        //v에는 3이라는 키값을 같는 값이 할당된다.
        //이와 같이 key값으로 해당 value값을 바로 찾기 때문에 많은 데이터를 관리할 때 효율적이다.
        //이렇게 찾을 경우 키값이 없으면 오류가 나끼 때문에 TryGetValue를 사용하다.
        //내부구조는 out이다
        string v = myDict[3];

        string s;
        //bool을 리턴한다 해당 키값이 있으면 true 없으면 false
        //(키값, 넣을 값)
        bool isit = myDict.TryGetValue(3123,out s);

        //Remove(키값)을 통해 해당 키와 값을 삭제 할 수도 있다.
        myDict.Remove(1);

        //내용을 전부 날리는 clear함수
        myDict.Clear();

        //Dictionary는 내부적으로 해쉬테이블을 사용한다.
        //메모리적으로 손해를 보긴한다.
        //메모리를 손해보고 성능을 얻는 방식
    }
}