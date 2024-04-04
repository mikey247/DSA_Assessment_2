using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_2_Solution
{
    internal class CustomerTree
    {
        private Node root;

        // Constructors
        public CustomerTree()
        {
            root = null;
        }

        public CustomerTree(Node root)
        {
            this.root = root;
        }

        public void InOrder()
        {
            inOrder(root);
        }

        public void inOrder(Node tree){
            {
                if (tree != null)  //not empty
                {
                    inOrder(tree.left);
                    //Console.Write(tree.Data + ",");
                    tree.Data.getInformation();
                    inOrder(tree.right);
                }
            }
        }

        public void PreOrder()
        {
            preOrder(root);
        }

        public void preOrder(Node tree)
        {
            {
                if (tree != null)  //not empty
                {
                    //Console.Write(tree.Data + ",");
                    tree.Data.getInformation();
                    preOrder(tree.left);
                    preOrder(tree.right);
                }
            }
        }

        public void PostOrder()
        {
            postOrder(root);
        }

        public void postOrder(Node tree)
        {
            {
                if (tree != null)  //not empty
                {
                    postOrder(tree.left);
                    postOrder(tree.right);
                    //Console.Write(tree.Data + ",");
                    tree.Data.getInformation();
                }
            }
        }

        public int Count()
        {
            return count(root);
        }

        private int count(Node tree)
        {
            if (tree == null)
                return 0;
            return count(tree.left) + count(tree.right) + 1;
        }


        private void insertItem(Customer customer, ref Node tree){
            if (tree == null)
                tree = new Node(customer);

            else if (customer < tree.Data)
                insertItem(customer, ref tree.left);

            else if (customer > tree.Data)
                insertItem(customer, ref tree.right);
        }

        public void InsertItem(Customer item)
        { insertItem(item, ref root); }


    }
}
