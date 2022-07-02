using System;

namespace AddingIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.add(10);
            int data = list.pop(10);
            Console.WriteLine("poped element is " + data);

        }
    }
}
