using System.Collections.Generic;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList Program");

            LinkedList objLinkedList = new LinkedList();
            objLinkedList.Add(70);
            objLinkedList.InsertFront(30);
            objLinkedList.InsertFront(56);
            objLinkedList.Display();

            Console.ReadLine();
        }
    }
}