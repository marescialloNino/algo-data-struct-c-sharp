using System;
namespace BinaryTree
{
    public class BinaryTree
    {
        public class Position
        {
            public Object Content;
            public Position LeftChild;
            public Position RightChild;
            public Position Parent;
        }

        private Position root;
        private int n;

        public BinaryTree()
        {
            root = null;
            n = 0;
        }

        public bool IsEmpty()
        {
            return (root == null); // n==0, Size()==0
        }

        public int Size()
        {
            return n;
        }

        public bool IsRoot(Position p)
        {
            return (p.Parent == null);
        }

        public void AddLeftChild(Position p, Object c)
        {
            Position newChild = new Position();
            newChild.Content = c;
            newChild.Parent = p;
            p.LeftChild = newChild;
        }

        public void AddRightChild(Position p, Object c)
        {
            Position newChild = new Position();
            newChild.Content = c;
            newChild.Parent = p;
            p.RightChild = newChild;
        }

        public void CreateRoot(Object c)
        {
            root = new Position();
            root.Content = c;
            // Exercise: make the new root 'replace' the old
            // one by keeping the 'topology' intact
            root.Parent = root.LeftChild = root.RightChild = null;
        }
    }
}
