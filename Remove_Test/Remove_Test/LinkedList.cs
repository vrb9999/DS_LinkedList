using System;
using System.Collections.Generic;
using System.Text;

namespace Remove_Test
{
    public class LinkedList
    {
        internal Node head;
        public void Add(int data)
        {
            Node node = new Node(data);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        public void Find(int value)
        {
            Node temp = head;
            int count = 0;

            while (temp.data != value)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine(value + " index value is " + count);
        }
        public int Length()
        {
            Node temp;
            int Count = 0;
            temp = this.head;
            while (temp != null)
            {
                Count++;
                temp = temp.next;
            }
            return Count;
        }

        public void AddAfter(int Ploc, int data)
        {
            Node temp;
            Node p;
            int loc = Ploc, i = 1;
            int leng = this.Length();
            if (loc > leng)
            {
                Console.WriteLine("Invalid Location");
                Console.WriteLine("Current list having ", leng);
            }
            else
            {
                p = this.head;
                while (i < loc)
                {
                    p = p.next;
                    i++;
                }
                Node node = new Node(data);
                temp = node;
                temp.next = p.next;
                Console.WriteLine("{0} inserted into after {1} linked list", node.data, p.data);
                p.next = temp;
            }
        }
        public void delete(int value) 
        {
            Node temp = this.head, prev = null;
            if (temp != null &&
                temp.data == value)
            {
                this.head = temp.next;
                Console.WriteLine(temp.data);
            }
            while (temp != null &&
                   temp.data != value)
            {
                prev = temp;
                temp = temp.next;
                Console.WriteLine("{0} Number is not present", value);
                break;
            }
            if (temp == null)
                return;
            prev.next = temp.next;
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.Write(temp.data + "\n");
            }
        }
        public int Size()
        {
            int size = 0;
            Node n = head;
            if (head == null)
            {
                Console.WriteLine($"Linked List is Empty, Size is {size}");
            }
            else
            {
                size = 1;
                while (n.next != null)
                {
                    n = n.next;
                    size++;
                }
                Console.WriteLine($"Linked List Size is {size}");
            }
            return size;
        }
    }
}
