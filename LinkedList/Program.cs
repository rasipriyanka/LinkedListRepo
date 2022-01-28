using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList listObj=new LinkedList();
            listObj.AddFront(70);
            listObj.AddFront(30);
            listObj.AddFront(56);
            listObj.Display();
        }
    }
}
