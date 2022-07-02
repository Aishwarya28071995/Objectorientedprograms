using System;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 30, 12, 32 };
            InsertionSort(array);
        }

        public static void InsertionSort(int[] array)
        {
            int n = array.Length;

            for(int i=1;i<n;i++)
            {

                int temp = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;

                }

                array[j + 1] = temp;
            }

            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
