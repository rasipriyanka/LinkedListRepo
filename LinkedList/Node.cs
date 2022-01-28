using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class Node
    {


        public int data;
        public Node next;
        public Node(int d) // creating Constructer
        {
            data = d;
            next = null;
        }
    }
}
