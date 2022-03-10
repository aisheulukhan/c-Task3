using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 467, 64, -2, 6, 46, -28, 9, 364, };
            NegativePotive(ref arr);
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
        static void NegativePotive(ref int [] arr)
        {
            for (int i =0 ; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr[i] = arr[i] * -1;
                }
            }
        }
    }
}
