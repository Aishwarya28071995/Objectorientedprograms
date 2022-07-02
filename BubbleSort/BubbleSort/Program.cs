using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 4, 3 };
            BubbleSort(array);
        }

        public static void BubbleSort(int[] array)
        {
            int length = array.Length;

            for(int i = 0; i < length - 1; i++)
            {
                for(int j=0;j<length-1;j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    
                    
                    }
                }
            }

            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
