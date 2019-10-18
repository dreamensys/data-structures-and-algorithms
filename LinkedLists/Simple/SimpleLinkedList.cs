using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists.Simple
{
    public class SimpleLinkedList
    {
        Node head;
        Node tail;
        public void AppendWithLoop(object data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(data);

        }

        public void Append(object data)
        {
            Node newItem = new Node(data);
            if (head == null)
            {
                head = newItem;
                tail = head;
                return;
            }

            tail.Next = newItem;
            tail = newItem;

        }

        public void Prepend(object data)
        {
            Node newItem = new Node(data);
            if (head == null)
            {
                head = newItem;
                return;
            }

            newItem.Next = head;
            head = newItem;
        }

        public void Delete(object data)
        {
            if (head == null) return;
            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }

        public int NodesCount()
        {
            if (head == null) return 0;
            int count = 1;
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
                count++;
            }

            return count;
        }

        public void WriteAll()
        {
            if (head == null) return;

            Node current = head;
            while (current.Next != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }

            Console.WriteLine(current.Data);
        }

    }
}
