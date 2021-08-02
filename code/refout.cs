using System;

namespace src
{
    class refout
    {
        //매개변수 ref
        static void AddOne(ref int number)
        {
            number +=1;
        }

        static int AddOne2( int number)
        {
            return number +=1;
        }

        //swap 예시
        //실제로 두개의 값을 바꿔야할 떄 차이점

        //1.복사한 값끼리 교체를 한 것 이기 때문에 원본값은 교환이 일어나지 않음
        static void swap1(int a, int b)
        {
            int temp =a;
            a =b;
            b = temp;

        }
        //2.원본값을 참조하여 접근하였기 때문에 원본값이 바뀜
        static void swap2(ref int a, ref int b)
        {
            int temp =a;
            a =b;
            b = temp;
        }

        //out 키워드 -> 반환하고 싶은 값이 여러개일 때 사용
        static public void Calcul(int a, int b, out int result1, out int result2)
        {
            result1 = a/b;
            result2 = a%b;
        }

        static public void organize()
        {
            int a = 0;
            //매개변수 ref -> 값을 복사하는것이 아닌 전달하는 인자의 주소를 참조하여 값에 접근한다
            //Addone의 경우 원본 값이 바뀌는것이기 때문에 값이 바뀌면 안될 경우 위험하다
            AddOne(ref a);
            //원본값은 변하지 않고 복사하여 값을 반환하는것이기 때문에 원본값이 변하면 안될 때 사용하자
            int b = AddOne2(a);
             Console.WriteLine("ref\n" + a+"\n"+b);

            swap1(a,b);
            Console.WriteLine("ref\n" + a+"\n"+b);
             
            swap2(ref a, ref b);
            Console.WriteLine("ref\n" + a+"\n"+b);
             
            Console.WriteLine("ref\n" + a);

            int reusult1 = 0;
            int result2 = 0;
            //out도 참조의 개념이기 때문에 out 키워드가 필요하다
            Calcul(10,3,out reusult1, out result2);
             Console.WriteLine("out\n" + reusult1 +"\n"+result2);
        }
    }
}