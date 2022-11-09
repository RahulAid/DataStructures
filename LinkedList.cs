using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node objNode = new Node(data);
            if (this.head == null)
            {
                this.head = objNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = objNode;
            }
            Console.WriteLine($"\n{objNode.data} is inserted into Linked List");
        }

        public void InsertFront(int new_data)
        {

            Node objnew_node = new Node(new_data);
            objnew_node.next = this.head;
            this.head = objnew_node;
            Console.WriteLine($"\n{objnew_node.data} is added at front");
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nLinkedList is empty");
                return;
            }
            Console.Write("\nLinked List ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}