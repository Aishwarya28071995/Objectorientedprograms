using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] array = { "apple", "banana", "mango", "orange" ,"pineapple"};
            Array.Sort(array);
            String data = "apple";

            int index = BinarySearch(array, array.Length, data);
            Console.WriteLine(index);
        }

       static int  BinarySearch(String[] array,int length,String data)
        {
            int l = 0;
            int r = length - 1;
            int mid = (l + r) / 2;

            while (l <= r)
            {

                if (data == array[mid])
                {
                    return mid;

                }

                if (data.CompareTo(array[mid]) < 0)
                {
                    r = mid - 1;
                }

                else if(data.CompareTo(array[mid]) > 0)
                {
                    l = mid + 1;
                }

            }

            return -1;
            


        }
    }
}
