using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treeee
{
    class Node
    {
        public Node Root { get; set; }
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
        public void Show(Node a)
        {
            if(a ==null)
            {
                return;
            }else
            {
                Console.Write(a.Data);
                Console.WriteLine();
                Show(a.GetLeft);
                Show(a.GetRight);
            }    
                
        }

        public bool Contains(int x)
        {
            return Contains(Root, x);
        }
        public void Remove (Node a,int x)
        {
            if (!a.Contains(x))
            {
                Console.WriteLine("Khong co gia tri cua x");
            }else
            {
                Delete(a, x);

            }    
        }
        private Node DelNode(Node Node, int x)
        {
            if (x == Node.Data)
            {
                return Node;
            }
            else if (x < Node.Data)
            {
                return DelNode(Node.GetLeft, x);
            }
            else
            {
                return DelNode(Node.GetRight, x);
            }
        }

        private void Delete(Node node, int x)
        {
            Node DelNode = this.DelNode(node, x);
            if(DelNode.GetLeft == null && DelNode.GetRight == null)
            {
                DelNode = null;
            }
            else if (DelNode.GetLeft!= null)
            {
                DelNode = SearchRight(DelNode.GetLeft);
                Delete(SearchRight(DelNode.GetLeft), DelNode.Data);
            }
            else
            {
                DelNode = SearchRight(DelNode.GetRight);
                Delete(SearchRight(DelNode.GetRight), DelNode.Data);
            }    

        }

        private Node SearchRight(Node x)
        {
            if (x.GetRight == null && x.GetLeft == null)
            {
                return x;

            }
            else if (x.GetRight != null)
            {
                return SearchRight(x.GetRight);
            }
            else
            {
                return SearchRight(x.GetLeft);
            }
        }

        private Node SearchLeft(Node x)
        {
            if (x.GetRight == null && x.GetLeft == null)
            {
                return x;

            }else if(x.GetLeft != null)
            {
                return SearchLeft(x.GetLeft);
            }else
            {
                return SearchLeft(x.GetRight);
            }    
        }

        //public void Add(int data)
        //{
        //    if (this.Contains(data))
        //    {
        //        Console.WriteLine("khong the add data");
        //    }else
        //    {
        //        this.Add(this.Root, data);
        //    }
        //}

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
        public void Add(Node Node, int data)
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
