﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListUcs
{
    public class DefaultLinkedList
    {
        public static void AddingElement()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(56);
            list.AddLast(30);
            list.AddLast(70);
            foreach (var item in list)
            {
                Console.WriteLine(item+" ");
            }
        }
    }
}
