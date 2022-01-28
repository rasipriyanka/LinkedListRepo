using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class LinkedList
    {
        public Node head;
             //---------------------------- creating method for a class----------------------------//
        public void AddFront(int new_data)
        {
            //-------------- Creating a object for class-------------------------------------------//
            Node new_node = new Node(new_data);

            //----- when we want to add any node at the front , we want the head to point to it----//
            new_node.next=this.head;

            //----- the previous head node is now the second node of linked list-------------------//
            this.head=new_node;

            Console.WriteLine("inserted into list" +" " + new_node.data);
        }
            //-------Display Method is used to display Elements-----------//
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