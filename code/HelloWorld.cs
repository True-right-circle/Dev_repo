using System;

namespace src
{
    class Program
    {
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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
