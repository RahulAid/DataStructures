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

        public void InsertBetween(int new_data)
        {
            int position = 2;
            Node objnew_Node = new Node(new_data);
            objnew_Node.data = new_data;
            objnew_Node.next = null;

            if (position < 1)
            {
                Console.Write("\nposition should be Greater or Equal to 1");
            }
            else if (position == 1)
            {
                objnew_Node.next = this.head;
                this.head = objnew_Node;
            }
            else
            {
                Node temp = new Node(new_data);
                temp = this.head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null)
                {
                    objnew_Node.next = temp.next;
                    temp.next = objnew_Node;
                }
                else
                {
                    Console.Write("\nThe previous node is null.");
                }
            }
            Console.WriteLine($"\n{objnew_Node.data} inserted at position {position}");
        }

        public void DeleteFirstElement()
        {
            if (this.head == null)
            {
                Console.WriteLine("\nList is Empty");
            }
            this.head = this.head.next;
            Console.WriteLine("\nRemoved first node");
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