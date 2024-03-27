using System;

public class Program
    {
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    static void SelectionSort(int[] array)
    {
        int min = 0;
        for(int i = 0; i < array.Length -1 ; i++)
        {
            min = i;

            for(int j = i + 1; j < array.Length; j++)
            {
                if ( array[j] < array[min] )
                {
                    min = j;
                }

            }
            Swap(ref array[i], ref array[min]);

        }
    }
        static void Main(string[] args)
        {
        int[] array = { 64, 25, 12, 22, 11 };
        Console.WriteLine($"정렬 전 배열 {string.Join(" , ", array)}");
        SelectionSort(array);
        Console.WriteLine($"정렬 후 배열 {string.Join(" , ", array)}");
    }
    }
