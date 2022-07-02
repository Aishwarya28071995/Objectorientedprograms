using System;

namespace FindYourNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N");
            int N = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of elements");
            int n = Int32.Parse(Console.ReadLine());
            int l = 0;
            int r = n - 1;
            int mid = (r + l) / 2;

           
            BinarySearch(N,l,r,mid);
        }

        public static void BinarySearch(int N,int l,int r,int mid)
        {
           
            if (mid == N)
            {
                Console.Write(mid);
                return;
            }

            else if (N>mid)
            {
                r = mid + 1;
                mid = (l + r) / 2;
                BinarySearch(N, l, r, mid);
            }
            else
            {
                l = mid - 1;
                mid = (l + r) / 2;
                BinarySearch(N, l, r, mid);
            }
        }
    }
}
