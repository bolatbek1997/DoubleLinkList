using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoubleLinkList
{
    class Program
    {
        static void Main(string[] args)
        {           

            DoubleLinkedList list = new DoubleLinkedList();
            list.InsertEnd("1");
            list.InsertEnd("2");
            list.InsertEnd("3");
            list.InsertEnd("4");
            list.InsertEnd("5");
            Console.WriteLine("List: " + list);
            Node link4 = list.FindNode(1);
            Console.WriteLine(list.size.ToString());
            list.InsertBefore(link4, "[4a]");
            list.InsertAtIndex(1, "bake");
            Console.WriteLine("List: " + list);
            Console.WriteLine(list.size.ToString());
            Console.Read();
        }
    }
}
