using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class LinkedList
    {
        public Node head;
        ///---------------- creating method for a class--------------------///
        public void AddAppend(int new_data)
        {
            ///---- Creating a object for class---------------------------///
            Node new_node = new Node(new_data);
            if (this.head == null)
            {
                this.head = new_node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("inserted into list" + " " + new_node.data);
        }
        ///-------Get last node reference-------------------------------///
        ///-------Method Starts------------------///
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        ////--------Method Ends------------------///
        
        ///--------------Displaying the elements------------------------///
        public void Display()
        {
            Console.WriteLine("Displaying Names");
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}