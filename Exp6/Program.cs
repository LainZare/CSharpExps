using System;

namespace Exp6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 2, 7, 4, 6, 3, 1, 9, 8, 5, 0 };

            Console.Write("Original: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            BubbleSort(arr);
            // SelectSort(arr);
            // InsertSort(arr);

            Console.Write("Sorted: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

        }

        // 冒泡排序
        public static void BubbleSort(int[] arr)
        {
            int i, j, temp;
            for (i = 0; i < arr.Length - 1; i++)
            {
                for (j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // 选择排序
        public static void SelectSort(int[] arr)
        {
            int i, j, min, temp;
            for (i = 0; i < arr.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }

        // 插入排序
        public static void InsertSort(int[] arr)
        {
            int i, j, temp;
            for (i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
        }
    }
}