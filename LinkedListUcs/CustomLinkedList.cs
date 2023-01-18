﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUcs
{
    public class CustomLinkedList
    {
        public Node head;
        public void AddLast(int data)
        {
            Node  newNode = new Node(data);
            if (head == null)
                head = newNode;
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void AddFirst(int data)
        {
            Node newNode=new Node(data);
            newNode.next = head;
            head = newNode;
            Console.WriteLine($"{newNode.data} is added into the list");
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        public void Display()
        {
            Console.WriteLine("Displaying Nodes ");
            Node temp = this.head;
            if(temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else
            {
                while(temp!= null)
                {
                    Console.WriteLine(temp.data+ " ");
                    temp = temp.next;
                }
            }
            Console.WriteLine();
            
        }
        
        
       

    }
}
