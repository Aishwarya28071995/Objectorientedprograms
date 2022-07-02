using System;

namespace WordsInLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] array = { "apple", "mango", "banana" };
            LinkedList linkedList = new LinkedList();

            for(int i=0;i<array.Length;i++)
            {
                linkedList.Add(array[i]);
                
            }
            String data = linkedList.pop("apple");
            Console.WriteLine(data);
        }
    }
}
