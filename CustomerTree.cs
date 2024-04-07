using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public String[] InOrder(){
            List<String> result = new List<String>();
            inOrder(root, result);
            return result.ToArray();    
        }

        public void inOrder(Node tree, List<String> result){
            if (tree != null){
                inOrder(tree.left, result);
                result.Add(tree.Data.getInformation());
                //Console.Write(tree.Data + ",");
                inOrder(tree.right, result);
            }
        }

        public String[] PreOrder(){
            List<String> result = new List<String>();
            preOrder(root, result);
            return result.ToArray();
        }

        public void preOrder(Node tree, List<String> result){
                if (tree != null){
                    result.Add(tree.Data.getInformation());
                    preOrder(tree.left, result);
                    preOrder(tree.right, result);
                }
        }

        public String[] PostOrder(){
            List<String> result = new List<String>();
            postOrder(root,result);
            return result.ToArray();
        }

        public void postOrder(Node tree, List<String> result){
                if (tree != null) {
                    postOrder(tree.left, result);
                    postOrder(tree.right, result);
                    result.Add(tree.Data.getInformation());
                }
        }

        public int Count(){
            return count(root);
        }

        private int count(Node tree) {
            if (tree == null)
                return 0;
            return count(tree.left) + count(tree.right) + 1;
        }


        private void insertItem(Customer customer, ref Node node){
            if (node == null){
                node = new Node(customer);
            } else if (customer.Name.CompareTo(node.Data.Name) <= 0){
                // If the new customer's name is less than or equal to the current node's customer's name, 
                // go to the left subtree
                if (node.left == null){
                    node.left = new Node(customer);
                } else {
                    insertItem(customer, ref node.left);    
                }
            }else{
                // If the new customer's name is greater than the current node's customer's name, 
                // go to the right subtree
                if (node.right == null){
                    node.right = new Node(customer);
                } else{
                    insertItem( customer, ref node.right);
                }
            }
        }

        public void InsertItem(Customer item){ 
            insertItem(item, ref root);
        }

        public Customer FindItem(string name){
            return findItem(name, root);
        }


        private Customer findItem(string name, Node tree) { 
            if (tree == null){
                return null;
            } else if (name.CompareTo(tree.Data.Name) == 0){
                return tree.Data;
            } else if (name.CompareTo(tree.Data.Name) < 0){
                return findItem(name, tree.left);
            } else{
                return findItem(name, tree.right);
            }
        }



    }
}
