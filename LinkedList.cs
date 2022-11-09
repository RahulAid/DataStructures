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

        public void InsertNewNumber(int new_number)
        {
            int position = 3;
            Node objnew_Node = new Node(new_number);
            objnew_Node.data = new_number;
            objnew_Node.next = null;

            if (position < 1)
            {
                Console.Write("\nPosition should be Greater or Equal to 1");
            }
            else if (position == 1)
            {
                objnew_Node.next = this.head;
                this.head = objnew_Node;
            }
            else
            {
                Node temp = new Node(new_number);
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
            Console.WriteLine($"\n{objnew_Node.data} is inserted at position {position}");
        }

        public Node Search(int value)
        {
            int position = 1;
            Node headValue = this.head;
            while (headValue != null)
            {
                if (headValue.data == value)
                {
                    Console.WriteLine($"\nInput {value} is present at position {position}");
                    return headValue;
                }
                position++;
                headValue = headValue.next;
            }
            return null;
        }

        public void DeleteAtPosition(int position)
        {
            if (position < 1)
            {
                Console.Write("\nPosition should be Greater or Equal to 1");
            }
            else if (position == 1 && head != null)
            {
                Node nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;
                

            }
            else
            {
                Node temp = new Node(position);
                temp = head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }
                }
                if (temp != null && temp.next != null)
                {
                    Node nodeToDelete = temp.next;
                    temp.next = temp.next.next;
                    nodeToDelete = null;
                }
                else
                {
                    Console.Write("\nThe node is already null");
                }
            }
            Console.Write($"\n40 has been Deleted from position {position} ");
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