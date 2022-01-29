using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList listObj=new LinkedList();
            listObj.AddLast(56);
            listObj.AddLast(70);
            listObj.InsertAtPosition(2, 30);
            listObj.Display();
        }
    }
}
