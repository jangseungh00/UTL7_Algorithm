using System;
public class Program
{
    static void QuckSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            // 피벗을 기준으로 집합 분할
            int pivotIndex = Partition(array, left, right);

            //  왼쪽 데이터 집합에 대해 퀵 정렬 재귀
            QuckSort(array, left, pivotIndex - 1);

            // 오른쪽 데이터 집합에 대해 퀵 정렬 재귀 호출
            QuckSort(array, pivotIndex + 1, right);
        }
    }
    static int Partition(int[] array,int left,int right)
    {
        // 전달된 부분 배열 첫번째 요소를 비교ㅕ 기준(피벗) 값으로 사용
        int first = left;
        int pivot = array[first];

        // 앞서 첫번째 요소의 기준 값으로 사용했기 때문에 인덱스를 증가한 후에 비교 진행
        ++left;

        while(left < right)
        {
            // 왼쪽 데이터 영역에서 피벗 값보다 큰 값을 찾을 때까지 left 인덱스 증가 처리
            // 큰 값을 찾으면 일단 멈춤
            while (left <= array.Length - 1 && array[left] <= pivot)
            {
                ++left;
            }

            // 그 다음, 데이터 영역에서 피벗 값보다 작은 값을 찾을 때까지 오른쪽에서 왼쪽으로 right 인덱스 감소 처리
            // 작은 값을 찾으면 일단 멈춤
            while ((right >=0) && array[right] > pivot)
            {
                --right;
            }
            // left와 right가 서로 교차 ( 만나지 ) 하지 않았으면, left와 right 위치의 값을 서로 교환
            if(left < right)
            {
                int tmp = array[left];
                array[left] = array[right];
                array[right] = tmp;
            }
            // 두 인덱스가 서로 교차를 했으면, 이번 턴에서의 검색이 완료되었음으로 종료
            else
            {
                break;
            }

            // 최종적으로, 피벗값과 왼쪽 데이터 집합의 마지막 요소(right)를 교환
            int tmp2 = array[first];
            array[first] = array[right];
            array[right] = tmp2;

            // 피벗값 반환 ( right 반환하는 이유는 앞에서 교환이 발생했기 때문)
            return right;
        }

    }
        static void Main(string[] args)
        {
        int[] array = { 3, 2, 7, 10, 1, 8, 9 };
        Console.WriteLine($"퀵 정렬 전 배열 {string.Join(" , ", array)}");

        QuckSort(array, 0, array.Length - 1);

        Console.WriteLine($"퀵 정렬 후 배열 {string.Join(" , ", array)}");

        }
}
