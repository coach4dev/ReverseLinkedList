using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node sample = GetSampleLinkedList();
            Console.WriteLine("Sample Linked List: ");
            PrintList(sample);

            Node reversed = ReverseList(sample);
            Console.WriteLine("Reversed Linked List: ");
            PrintList(reversed);
            
            Console.ReadLine();
        }

        static void PrintList(Node Head) 
        {
            var node = Head;
            Console.WriteLine();
            while (node != null) 
            {
                Console.Write(node.Value + " -> ");
                node = node.Next;
            }
            Console.Write("null");
            Console.WriteLine();
        }

        static Node GetSampleLinkedList() 
        {
            Node node1 = new Node() { Value = 1 };
            Node node2 = new Node() { Value = 2 };
            Node node3 = new Node() { Value = 3 };
            Node node4 = new Node() { Value = 4 };

            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            return node1;
        }

        static Node ReverseList(Node head) 
        {
            if (head == null)
                return null;
            if (head.Next == null)
                return head;
            Node prev = null;
            Node curr = head;
            while (curr != null) 
            {
                Node temp = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = temp;
            }
            return prev;
        }
    }
}
