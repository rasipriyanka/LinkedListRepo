//---------Dependencies--------------------//
using System;
using System.Collections.Generic;
using System.Text;
//---------------Namespace----------------------------//
namespace LinkedList
{
    internal class LinkedList
    {
        public Node head;
        public void AddLast(int new_data) // creating method for a class
        {
            Node new_node = new Node(new_data); // Creating a object for Node.class
            if (this.head == null)
            {
                this.head = new_node; //assigning the elements to the head
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
        //this method is for displaying the elements in linked list
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
        //this method is used for adding the valuein particular position
        public void InsertAtPosition(int position, int new_data) 
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            if (position == 1)
            {
                Node new_node = new Node(new_data);
                new_node.next= this.head;
                this.head = new_node;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node new_node = new Node(new_data);
                        new_node.next = this.head.next;
                        this.head.next = new_node;
                        break;
                    }
                    this.head=this.head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position out of range");
            }
            Console.WriteLine("Inserted Value is " + head.next.data);
        }
    }
}