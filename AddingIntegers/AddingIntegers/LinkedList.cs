using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingIntegers
{
    internal class LinkedList
    {
        public static Node head;
        public void add(int data)
        {
            Node node = new Node(data);
            if (node == null)
            {
                head = node;
            }
            else
            {
                node.next = head;
                head = node;
                //Console.WriteLine(head.data);
            }

        }

        public int pop(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return 0;
            }
            else
            {
                Node temp = head;
                // Console.WriteLine(temp.data);
                while (temp.next != null)
                {
                    if (temp.data==data)
                    {
                        Console.WriteLine(temp.data);
                        return temp.data;

                    }
                    else
                    {
                        LinkedList list = new LinkedList();
                        list.add(data);
                    }
                    temp = temp.next;
                }

            }
            return 0;
        }
    }

    }


