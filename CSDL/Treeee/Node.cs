using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treeee
{
    class Node
    {
        private Node Root = null;
        public int Data { get; set; }
        public Node GetLeft { get; set; }
        public Node GetRight { get; set; }
        public Node()
        {

        }
        public Node(int a)
        {
            this.Data = a;
            this.GetLeft = null;
            this.GetRight = null;
        }
        public bool Contains(int x)
        {
            return Contains(this.Root, x);
        }
        public void Add(int data)
        {
            if (this.Contains(data))
            {
                Console.WriteLine("khong the add data");
            }else
            {
                this.Add(this.Root, data);
            }
        }

        public int Height()
        {
            return Height(Root);
        }
            
        private int Height(Node Node)
        {
            if(Node == null)
            {
                return 0;
            }else
            {
                return 1 + Math.Max(Height(Node.GetLeft), Height(Node.GetRight));
            }    
        }
        private bool Contains(Node Node, int x)
        {
            if (Node == null)
            {
                return false;
            }
            else if (x == Node.Data)
            {
                return true;
            }
            else if (x< Node.Data)
            {
                return Contains(Node.GetLeft, x);
            }else
            {
                return Contains(Node.GetRight, x);
            }
        }
        private void Add(Node Node, int data)
        {

            if (Node == null)
            {
                Node = new Node(data);
            }
            else if (data < Node.Data)
            {
                Add(Node.GetLeft, data);
               
            }else
            {
                Add(Node.GetRight, data);
            }
        }
    }
}
