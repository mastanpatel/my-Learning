using System;

namespace LinkedList
{
    class Program
    {
       

        static void Main(string[] args)
        {
            LinkedListOperations ls = new LinkedListOperations();

            ls.insertElementBegin(5);
            ls.insertElementBegin(2);
            ls.insertElementBegin(23);
            ls.insertElementInbetween(10, 2);
            ls.PrintList();
            ls.deleteElement(10);
            Console.WriteLine();
            ls.PrintList();
            ls.deleteList();
            Console.WriteLine();
            ls.PrintList();
            Console.WriteLine("Implemntation of DLL \n");

            //// Implemntation of DLL
            OperationsOnDDL dll = new OperationsOnDDL();

            dll.push(11);
            dll.push(31);
            dll.addBeforeNode(dll.Head.next, 123);
            dll.addAfterNode(dll.Head.next, 1);
            dll.PrintList();

            Console.ReadKey();


        }
    }
}
