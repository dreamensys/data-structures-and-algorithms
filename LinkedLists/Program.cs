using LinkedLists.Simple;
using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TODO: Measure and track the execution time */
            SimpleLinkedList list = new SimpleLinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append("Four");
            list.Append("Five");
            list.Delete(2);
            list.Prepend("Zero");
            list.WriteAll();
            Console.Read();
        }
    }
}
