//---------Dependencies--------------------//
using System;
using System.Collections.Generic;
using System.Text;
//---------------Namespace----------------------------//
namespace LinkedList
{
     class LinkedList
    {
        public Node head;
        public void AddLast(int new_data) // creating method for a class
        {
            Node new_node = new Node(new_data); // Creating a object for Node.class
            if (this.head == null)
            {
                this.head = new_node; //assigning the elemnts to the head
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = new_node;
            }
            Console.WriteLine("inserted into list" + " " + new_node.data);
        }
        public Node GetLastNode() //this method for getting the last node reference
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void Display()//this method is for displaying the elements in linked list
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
        public int search(int value)  //this method is used for finding the value
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return value;
                }
                temp = temp.next;
            }
            Console.WriteLine("{0} is not present", value);
            return 0;
        }
    }
}