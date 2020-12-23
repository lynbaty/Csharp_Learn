using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDL
{
    class Program
    {
        static void Main(string[] args)
        {
            Node a = new Node(24);
            SingleLinkedList Nodehead = new SingleLinkedList(a);
            InsertFrontNode(Nodehead, 12);
            InsertFrontNode(Nodehead, 23);
            InsertFrontNode(Nodehead, 18);
            InsertFrontNode(Nodehead, 11);
            Node x = Nodehead.head;
            while (x != null)
            {
                Console.WriteLine(x.data);
                x = x.next;
            }


        }
        static void InsertFrontNode(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;

        }
        static void InsertFrontDNode(DoublyLinkedList DoublyList, int new_data)
        {
            DNode new_node = new DNode(new_data);
            if (DoublyList.head != null)
            {
                DoublyList.head.prev = new_node;
            }
            new_node.next = DoublyList.head;

            DoublyList.head = new_node;
        }
        internal void InsertLastNode(SingleLinkedList SinglyList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (SinglyList.head == null)
            {
                SinglyList.head = new_node;
                return;
            }
            Node LastNode = GetLastNode(SinglyList);
            LastNode.next = new_node;
  
           
        }
        internal void InsertLastDNode(DoublyLinkedList DoublyList, int new_data)
        {
            DNode new_node = new DNode(new_data);
            if(DoublyList.head == null)
            {
                DoublyList.head = new_node;
                new_node.prev = null;
                return;
            }
            DNode LastNode = GetLastDNode(DoublyList);
            LastNode.next = new_node;
            new_node.prev = LastNode;
 
        }
        internal Node GetLastNode(SingleLinkedList SinglyList)
        {
            Node temp = SinglyList.head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        internal DNode GetLastDNode(DoublyLinkedList DoublyList)
        {
            DNode temp = DoublyList.head;
            while(temp.next !=null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    internal class DNode
    {
        internal int data;
        internal DNode next;
        internal DNode prev;
        public DNode(int d)
        {
            data = d;
            next = null;
            prev = null;

        }
    }
    internal class SingleLinkedList
    {
        internal Node head;
        public SingleLinkedList(Node a)
        {
            head = a;
        }
    }
    internal class DoublyLinkedList
    {
        internal DNode head;
        public DoublyLinkedList(DNode a)
        {
            head = a;
        }
        
    }


}
