using System;
using System.Threading.Tasks.Dataflow;

public class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }


    // 버블 정렬
    static void BubbleSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {   
                // 두개씩 비교
                if (array[j] >= array[j + 1])
                {
                    //int tmp = array[j];
                    //array[j] = array[j + 1];
                    //array[j + 1] = tmp;

                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }
    static void Main(string[] args)
    {
        int[] array = { 5, 2, 8, 4, 1 };
        //int tmp;

        //for (int i = 0; i < array.Length - 1; i++)
        //{
        //   for(int j = 0; j < array.Length  -i - 1 ; j++)
        //    {
        //        if (array[j] >= array[j + 1])
        //        {
        //            tmp = array[j];
        //            array[j] = array[j + 1];
        //            array[j + 1] = tmp;
        //        }
        //    }
        //}
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Console.Write(array[i].ToString());
        //}


        Console.WriteLine($"정렬 전 배열 : {string.Join(",", array)}");

        BubbleSort(array);

        Console.WriteLine($"정렬 후 배열 : {string.Join(",", array)}");

        Console.ReadKey();
    }
}