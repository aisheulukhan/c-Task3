using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 467, 64, -2, 6, 46, 28, 9, 364, };
            
            Swap(arr);
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
        static void Swap(int[] arr)
        {

            int min = 0;
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[min] > arr[i])
                    min = i;
                if (arr[max] < arr[i])
                    max = i;
              
            }
            arr[min] = arr[max] + arr[min];
            arr[max] = arr[min] - arr[max];
            arr[min] = arr[min] - arr[max];

        }

    }
}
