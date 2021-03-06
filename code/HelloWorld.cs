using System;

namespace src
{
    class Program
    {
        //열거법
        enum Choice
        {
            rock,
            paper,
            scissors
        }

        //1. Main 함수는 프로젝트 내에서 유일해야한다.
        //byte(1바이트 0~255) short(2byte -3만 ~ 3만) int(4byte -21억 ~ 21얼), long(8byte)
        //sbyte -> (-128 ~ 127), usort(2byte 0~ 6만 5천) uint(0~43djr) ulong 
        //id와 같이 수시로 생성되는 값들은 long으로 만드는게 유리할지도?
        //int의 범위를 벗어난 케이스도 있다.

        //ex 문명 게임에서 간디의 공격성은  byte로 지정되어있었고
        //특정 조건에서 공격성이 내려갔는데 0에서 --처리가 되어서
        //언더 플로우가 발생하여 255가 되어 매우 공격적으로 변하는 버그가 있었음

        //10진수 : 우리가 평상시에 사용하는 숫자표현
        //->0,1,2,3,4,5,6,7,8,9

        //2진수
        //0~1로 표현
        //0과 1로만 표현이 가능하므로 해당 범위를 벗어나면 자리수를 하나 더 만들어서 0과 1로 표현
        // 2진수는 0b라고 표기한다.
        // 2-> 0b10, 3-> 0b11, 4-> 0b100

        //16진수
        //0~9까지는 숫자로 표기가 가능 a(10)b,c,d,e,f(15)로 표기
        //16진수는 0x로 표기한다 -> 0x00 , 0x01 ~ 0x0f
        //0x10 -> 16
        // 2진수 -> 16진수 
        //ob10001111 : 4개씩 끊어서 바꾼다 1000 -> 8, 1111->f  -> 0x8f

        //2의보수 -> 비트 중 제일 왼쪽의 비트를 부호로 사용하는것이다.
        //빠르게 음수를 찾기 쉽다.
        //00110100 -> 52 -> 0과 1을 반전 시킨다 -> 11001011 -> 1을 더한다 -> 11001100 -> -52
        //8개의 비트가 모여 1byte가된다.


        //bool type ->참 혹은 거짓 1 or 0 값을 가진다.
        //컴퓨터가 연산시 1비트보다 1byte가 더 빠르기 때문에 bool은 1바이트의 크기를 갖는다.
        bool b;

        // 소수 float, double 등
        // 크기는 정수와 비슷하지만 연산은 정수 연산보다 비싸다
        // float -> 4바이트, double 8바이트 -> 범위도 더크고 정밀하게 표현 가능
        float f = 3.14f; //7자리까지는 정밀하고 그 이상은 오차가 생긴다.
        double d = 3.14;

        // 문자, 문자열
        // char, string

        //char -> 2byte
        //문자를 표현하기 위한 타입 : 하나의 문자만
        char c = 'c';

        //string char의 집합체
        string str = "abcd";

        static void organize()
        {
            //형변환
            // 1. 범위가 다른 경우 ex) int(4byte) -> short(2byte) : 명시적 형변환은 가능(캐스팅)
            int a = 1000;
            short sh = (short)a; //int가 값이 더 크기 떄문에 값에 따라 결과물 소실이 일어난다
            //-> 반대의 경우는 문제가 없다 short -> int로 형변환
            // 2. 범위는 같거나 비슷하나 부호가 다를경우
            // byte -> sbyte 
            //오버플로우가 일어나거나 언더플로우가 일어난다.

            //후위 연산 vs 전위 연산
            int hp = 100;
            //최종적으로 101로 만드는 연산이나
            //hp++은 호출되는 라인 이후부터 101로 증가하며 ++hp는 호출되는 라인부터 101로 시작한다.
            hp++;
            ++hp;

            //비트 연산 :<< >> &(and) |(or) ^(xor) ~(not)
            int num = 1;
            num = num << 1;
            // 1-> 0000 0001 -> 왼쪽으로 1칸 이동하라 -> 0000 0010 :2
            num = 1;
            num = num << 3; //왼쪽으로 3칸 이동하라 ->  0000 1000
            num = num >> 1; //오른쪽으로 1칸 이동하라 -> 0000 0100
            //주의 1000 01000 0000 00010 일경우(부호를 갖을 경우) 옮기고 맨왼쪽을 1로 바꿔주기 때문에 값이
            //이상해 질 수 있어 uint등 usinged 타입으로 사용하는것이 좋다

            //& -> 둘다 참일경우만 참 (둘다 1이면 1 이외는 0)
            //| -> 둘중 하나라도 참이면 참
            //^ -> 비교하는 두값이 서로 다를 경우만 참
            //! 현쟈의 값 0과 1 반전

            //^연산은 암호화에 주로 사용된다 -> 같은 값으로 ^두번하면 원래 값이 되는것을 사용
            //서버로 특정 key값으로 ^ 연산하여 값을 보내고 받는곳도 key값을 받아 ^연산하면 원래값
            //중간에 가로챈 사람은 key값을 모르면 원래값을 모르게 된다.
            int id = 123;
            int key = 401;

            int aid = id ^ key; // 암호화가 된다.
            int bid = aid ^ key; // 다시 123이 된다.

            Console.WriteLine(num);
            //Console.WriteLine("Hello World!");
            //연산의 우선순위 외울 필요 없고 ()를 활용하자
            // 1. ++, --
            // 2. * / %
            // 3. + -
            // 4. << >>
            // 5. < >
            // 6. == !=
            // 7. &
            // 8. ^
            // 9. | ....

            //var 키워드 -> 남용하지 않는게 좋다 명시적으로 표현하는게 가독성에 좋다.

            //삼항 연산자 조건 ? 참일 떄의 값 : 거짓일 떄의 값
            //aid가 1보다 큰게 참이면 50 아니면 100 반환
            int three = aid > 1 ? 50 : 100;

            //상수 const -> 한번 설정한 이후에는 값을 바꾸지 않겠다
            const int cint = 3;
            //cint =4; -> error

            //열거형
            Choice enuma = Choice.paper;

            //switch문에 하드코딩된 숫자를 넣지말자
            //break -> 소속된 반복문 또는 switch문을 빠져나간다.
            //continue 반복문에서 아래부분을 실행하지 않고 다음 루프로 넘어간다.

            //함수에서 복사와 참조
            //매개변수로 일반 데이터 타입을 전달하면 값이 복사가 되어 아예 다른 메모리상의 값이 전달된다.
            //매개변수 앞에 ref값을 넣어야 넘겨받는 값의 주소를 참조하여 해당 값에 직접 접근한다.
        }
    }
}
