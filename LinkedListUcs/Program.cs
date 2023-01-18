using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUcs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LinkedList UCs");
            Console.WriteLine("Please chooes as per given Option \n " +
                "1: Adding Element by BuiltIn-LinkedList\n" +
                "2:Adding element by using custom LinkedList\n" +
                "3:AddFirst In LinkedList and Displaying");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
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
                    CustomLinkedList customLinkedList1=new CustomLinkedList();
                    customLinkedList1.AddFirst(70);
                    customLinkedList1.AddFirst(30);
                    customLinkedList1.AddFirst(56);
                    customLinkedList1.Display();
                    break;
                default:
                    Console.WriteLine("Invalid Option Selected .Please try again");
                    break;
            }
            Console.ReadLine();

        }
    }
}
