using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        private Node Root { get; set; }
        public int Height;
        public int Count;

        private int CountRecursion(Node n)
        {
            throw new NotImplementedException();
        }

        public void Insert(char val)
        {
            if (Root == null)
            {
                Root = new Node(val);
            }
            else
            {
                Insert(Root, val);
            }
        }

        private void Insert(Node cur, char val)
        {
            if (val >= cur.Value && cur.RightChild == null)
            {
                cur.RightChild = new Node(val);
                return;
            }
            if (val < cur.Value && cur.LeftChild == null)
            {
                cur.LeftChild = new Node(val);
                return;
            }

            if (val >= cur.Value)
                Insert(cur.RightChild, val);
            else if (val < cur.Value)
                Insert(cur.LeftChild, val);
        }

        public bool Search(char val)
        { 
            throw new NotImplementedException();
        }

        private bool Search(Node cur, char val)
        {
            if (val >= cur.Value && cur.RightChild == null)
            {

            }
                throw new NotImplementedException();
        }

        public bool Remove(char val)
        {
            throw new NotImplementedException();
        }

        private bool Remove(Node cur, char val)
        {
            if (cur == null) //return cur;

            if (val < cur.Value)
                /*cur.LeftChild = Remove(cur.LeftChild, val)*/;
            else if (val > cur.Value)
                /*cur.RightChild = Remove(cur.RightChild, val)*/;
            else
            {

            }

            //return Root;
            throw new NotImplementedException();
        }

        public void balance()
        {

        }
        public void PreOrderPrint()
        {

        }
        private void PreOrderPrint(Node n)
        {

        }
        public void InOrderPrint()
        {

        }
        private void InOrderPrint(Node n)
        {

        }
        public void PostOrderPrint()
        {

        }
        private void PostOrderPrint(Node n)
        {

        }
        public bool yolo()
        {
            throw new NotImplementedException();
        }
    }
}
