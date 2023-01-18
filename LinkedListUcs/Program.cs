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
                "2:Adding element by using custom LinkedList\n");
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
                default:
                    Console.WriteLine("Invalid Option Selected .Please try again");
                    break;
            }
            Console.ReadLine();

        }
    }
}
