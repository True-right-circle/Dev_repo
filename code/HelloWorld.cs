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

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}