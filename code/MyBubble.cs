using System;

class MyBubble
{
    public void BubbleFunc()
    {
        //Create Array
        Random rand = new Random();
        int length = rand.Next(10, 20);
        int[] needsort = new int[length];

        Console.WriteLine("length : " + length);

        for (int i = 0; i < needsort.Length; ++i)
        {
            needsort[i] = rand.Next(1, 1000);
            Console.Write(needsort[i] + ", ");
        }

        Console.Write("\n\n");

        BubleSort(needsort);
    }

    static void BubleSort(int[] arrays)
    {
        //배열 내에서 가장 작은 수를 찾으며 순회한다.
        //순회 중 나보다 작은 값이 있으면 서로 자리를 바꾼다.
        //이후 제외한 배열끼리 위의 과정을 반복한다.
        
        //제일 작은 인덱스 값을 위한 pivot
        int minPivot = 0;
        
        //0번째 인덱스부터 전체를 순회한다.
        for (int i = 0; i < arrays.Length; ++i)
        {
            //순회를 하는인덱스 0
            minPivot = i;

            //i번째 인덱스로 남은 전체 인덱스를 순회
            for (int j = i; j < arrays.Length; ++j)
            {
                //순회중에 본인보다 작은 값을 찾으면 해당 인덱스가 가장 작은
                //인덱스이므로 해당 인덱스 값을 기억
                if(arrays[minPivot]>arrays[j])
                {
                    minPivot = j;
                }
            }

            //i(즉 첫번째는 0번쨰 인덱스)로 전체 나머지 배열을 순회하고 나온 후
            //가장 작은 값을 찾은 해당 인덱스 위치라 minPivot에 저장되어 있으니
            //해당 값과 순회한 값을 바꿔준다

            //[Swap]
            //값 복사를 위한 temp
            int temp = arrays[i];
            //현재값을 최소값과 값을 교체
            arrays[i] = arrays[minPivot];
            //최소값 위치에 순회한 값을 치환
            arrays[minPivot] = temp;

            //이후 for문으로 돌아가 다음 인덱스로 나머지 배열 순회 위의 내용 반복
        }

        foreach(int n in arrays)
        {
            Console.Write(n+", ");
        }
    }

}