using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUcs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList UCs");
            Console.WriteLine("Please choose as per the given options -\n" +
                "1: Adding elements by BuiltIn-LinkedList\n" +
                "2: Adding elements by using Custom LinkedList\n" +
                "3: AddFirst in LinkedList \n" +
                "4: Append in LinkedList and Displaying\n" +
                "5: Insertion between elements.\n" +
                "6: Deleting First Element from the LL.\n" +
                "7: Deleting Last Element from the LL.");
            int options = Convert.ToInt32(Console.ReadLine());
            switch (options)
            {
                case 1:
                    DefaultLinkedList.AddingElement();                                 
                    break;
                case 2:
                    CustomLinkedList customLinkedList = new CustomLinkedList();
                    customLinkedList.AddLast(56);                                       
                    customLinkedList.AddLast(30);
                    customLinkedList.AddLast(70);
                    customLinkedList.Display();
                    break;
                case 3:
                    CustomLinkedList customLinkedList1 = new CustomLinkedList();
                    customLinkedList1.AddFirst(70);                                   
                    customLinkedList1.AddFirst(30);
                    customLinkedList1.AddFirst(56);
                    customLinkedList1.Display();
                    break;
                case 4:
                    CustomLinkedList customLinkedList2 = new CustomLinkedList();
                    customLinkedList2.Append(56);                                     
                    customLinkedList2.Append(30);
                    customLinkedList2.Append(70);
                    customLinkedList2.Display();
                    break;
                case 5: //add nodes 56 and 70 .insert 30 between 56 and 70 . sequence -> 56,30,70 .
                    CustomLinkedList customLinkedList3 = new CustomLinkedList();
                    customLinkedList3.AddFirst(56);
                    customLinkedList3.AddLast(70);
                    customLinkedList3.InsertBetweenNodes(56, 30, 70);                   
                    customLinkedList3.Display();
                    break;
                case 6:
                    CustomLinkedList customLinkedList4 = new CustomLinkedList();
                    customLinkedList4.AddFirst(56);
                    customLinkedList4.AddLast(30);
                    customLinkedList4.AddLast(70);
                    customLinkedList4.Display();
                    customLinkedList4.RemoveFirst();            
                    customLinkedList4.Display();
                    break;
                case 7:
                    CustomLinkedList customLinkedList5 = new CustomLinkedList();
                    customLinkedList5.AddFirst(56);
                    customLinkedList5.AddLast(30);
                    customLinkedList5.AddLast(70);
                    customLinkedList5.Display();
                    customLinkedList5.RemoveLast();             
                    customLinkedList5.Display();
                    break;
                default:
                    Console.WriteLine("Invalid option selected .Please try again !");
                    break;
            }
            Console.ReadLine();
        }
    }
}