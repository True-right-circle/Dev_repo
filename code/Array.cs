//Data Structure
//Array 2021.08.12 ~ 08.21
using System;

class MyArray
{
    public void SetMyArray()
    {
        //int 형식의 값들을 여러개 갖고있을 수 있다.
        //배열의 크기는 한 번 선언 하면바꿀 수 없다.
        //인덱싱은 0부터 시작해서 0,1,2,3,4로 총 5개로 매칭되어있다.
        //처음에 선언핝 자료형으로만 값을 채워 넣을 수 있다.
        int[] scores = new int[5];
        scores[0] = 10;
        scores[1] = 20;
        scores[2] = 30;
        scores[3] = 40;
        scores[4] = 50;

        //또 다른 배열 선언법
        int[] scores2 = new int[5] { 10, 20, 30, 40, 50 };
        int[] score3 = { 10, 20, 30, 40, 50 };

        for (int i = 0; i < scores.Length; ++i)
        {
            Console.Write(scores[i]);
        }

        //for문을 좀 더 쉽게 foreach
        // a는 scores 배열의 안의 인자를 순회한다
        //가독성 및 인덱싱 실수를 하는 실수는 예방 할 수 있다.
        foreach (int a in scores)
        {
            Console.Write(a);
        }

        //배열은 참조 타입이다. 복사가 일어나지 않는다.
        int[] score4 = scores;
        //->score4의 값을 바꾸면 scores 원본 값이 바뀐다.

        int[] exScores = new int[10] { 10, 343, 45, 3493, 2, 11, 3453, 234, 89, 7348 };
        Console.Write("\n" + GetHighestScore(exScores));
        Console.Write("\n" + GetAverageScore(exScores));
        Console.Write("\n" + GetindexOf(exScores, 45));
        Console.Write("\n\n");
        Sort(exScores);

    }

    static int GetHighestScore(int[] scores)
    {
        int highest = scores[0];
        for (int i = 0; i < scores.Length - 1; ++i)
        {
            if (scores[i] < scores[i + 1])
            {
                highest = scores[i + 1];
            }

        }
        return highest;
    }

    static int GetAverageScore(int[] scores)
    {
        int sum = 0;
        foreach (int k in scores)
        {
            sum += k;
        }
        return (sum / scores.Length);
    }

    static int GetindexOf(int[] scores, int value)
    {
        int index = 0;
        for (int i = 0; i < scores.Length; ++i)
        {
            if (scores[i] == value)
            {
                index = i;
            }
        }
        return index;
    }

    //10,343,45,3493,2,11,3453,234,89,7348
    static void Sort(int[] scores)
    {
        for (int i = 0; i < scores.Length; ++i)
        {
            //제일 작은 숫자 index를 찾는다 i ~ scores.length -1까지
            int min = i;
            for (int j = i; j < scores.Length; ++j)
            {
                if (scores[j] < scores[min])
                {
                    min = j;
                }
                
            }
            //swap
            int temp = scores[i];
            scores[i] = scores[min];
            scores[min] = temp;   
        }

        foreach(int n in scores)
        {
            Console.Write(n+"\n");
        }
    }


}

