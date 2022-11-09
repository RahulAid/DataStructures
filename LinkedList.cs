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
            Console.WriteLine($"\n{objNode.data} inserted into Linked List");
        }

        
        public void DeleteLastElement()
        {
            if (head == null)
            {
                Console.WriteLine("\nLinked List Empty");
            }
            if (head.next == null)
            {
                Console.WriteLine("\nLinked List Empty");
            }
            Node objNew_Node = head;
            while (objNew_Node.next.next != null)
            {
                objNew_Node = objNew_Node.next;
            }
            objNew_Node.next = null;
            Console.WriteLine("\nRemoved Last Node");
        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\nLinkedList is empty");
                return;
            }
            Console.Write("\nLinked List  ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}