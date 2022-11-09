using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");

            LinkedList objLinkedList = new LinkedList();
            objLinkedList.Add(56);
            objLinkedList.Add(30);
            objLinkedList.Add(40);
            objLinkedList.Add(70);           
            objLinkedList.sortList();
            objLinkedList.Display();
            

            Console.ReadLine();
        }
    }
}