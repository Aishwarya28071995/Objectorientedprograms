using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsInLinkedList
{
    internal class LinkedList
    {
        public static Node head;
        public void Add(String data)
        {
            Node node = new Node(data);
            if(node==null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
                Console.WriteLine(head.data);
            }
        }

        public String pop(String name)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return null;
            }
            else
            {
                Node temp = head;
               // Console.WriteLine(temp.next);
                while (temp.next != null)
                {
                    if (temp.data.CompareTo(name)==0)
                    {
                        Console.WriteLine(temp.data);
                        return temp.data;

                    }
                    temp = temp.next;
                }

            }
            return null;
        }
    }
}
