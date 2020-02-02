using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeSort
{
    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }

        public Node ReturnRoot()
        {
            return root;
        }

        public void Insert(int id)
        {
            Node newNode = new Node();
            newNode.item = id;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftc;
                        if (current == null)
                        {
                            parent.leftc = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightc;
                        if (current == null)
                        {
                            parent.rightc = newNode;
                            return;
                        }
                    }
                }
            }
        }

        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                Preorder(Root.leftc);
                Preorder(Root.rightc);
            }
        }

        public void InOrder(Node Root)
        {
            if (Root != null)
            {
                InOrder(Root.leftc);
                Console.WriteLine(Root.item + " ");
                InOrder(Root.rightc);
            }
        }

        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.leftc);
                Postorder(Root.rightc);
                Console.Write(Root.item + " ");
            }
        }
    }
}
