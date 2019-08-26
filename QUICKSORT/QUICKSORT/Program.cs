using System;

namespace QUICKSORT
{
    public class Program
    {
        public static int[] intArray = { 1, 3, 2, 6, 7, 5, 4 };
        public static void Main(string[] args)
        {
            Console.WriteLine("Original Array : ");
            PrintArray(intArray);
            QuickSort(intArray, 0, 6);
            Console.WriteLine("Quick sorted Array : ");
            PrintArray(intArray);
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            int i, j, pivot, temp = 0;

            if (arr.Length > right && left < right)
            {
                i = left;
                j = right;
                pivot = arr[(left + right) / 2];

                while (i < j)
                {
                    while (arr[j] > pivot) j--;

                    while (i < j && arr[i] < pivot) i++;

                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }

                QuickSort(arr, left, i - 1);
                QuickSort(arr, i + 1, right);
            }
            else
            {
                return;
            }
        }

        public static void PrintArray(int[] arr)
        {
            int i = 0;
            foreach(int digit in arr)
            {
                Console.Write(digit);
                if(arr.Length -1 != i)
                {
                    Console.Write(", ");
                }
                i++;
            }
            Console.WriteLine();
        }
    }
}
