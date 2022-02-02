using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList listObj = new LinkedList();
            listObj.AddLast(56);
            listObj.AddLast(30);
            listObj.AddLast(70);
            listObj.Display();
            listObj.deleteNode(40);
            listObj.Display();
           
        }
    }
}

