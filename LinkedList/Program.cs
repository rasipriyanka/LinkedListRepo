using System;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList listObj=new LinkedList();
            listObj.AddLast(56);
            listObj.AddLast(30);
            listObj.AddLast(70);
            listObj.Display();
            int res = listObj.search(30);
            if (res == 0)
            {
                Console.WriteLine("{0} is not present", res);
            }
            else
            {
                Console.WriteLine("{0} is present", res);
            }

        }
    }
    }

