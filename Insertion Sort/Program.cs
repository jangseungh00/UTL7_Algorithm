using System;
    public class Program
    {
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            // 일단 앞의 순서와 비교해 정렬이 된 상태면 건너뜀
            if (array[i] >= array[i - 1])
                continue;

            // 정렬

            // 비교를 위해 현재 값 저장
            int keyValue = array[i];

            for (int j = i; j > 0; j--)
            { 
                if (array[j -1] > keyValue)
                {
                    array[j] = array[j - 1];
                    array[j - 1] = keyValue;
                }
                else
                {
                    break;
                }
            }

            
        }
    }

        static void Main(string[] args)
        {
        // 자료 집합
        int[] array = { 8, 5, 2, 7, 3, 1, 4, 6 };

        // 정렬 전 배열 호출
        Console.WriteLine($"정렬 전 배열 {string.Join(" , ", array)}");

        // 정렬.
        InsertionSort(array);
        // 정렬 후 배열 호출
        Console.WriteLine($"정렬 후 배열 {string.Join(" , ", array)}");

        Console.ReadKey();
    }
    }

