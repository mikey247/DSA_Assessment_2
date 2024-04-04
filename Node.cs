using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_2_Solution
{
    internal class Node
    {
        public Customer data;
        public Node left;
        public Node right;
        public Node(Customer data)
        {
            this.data = data;
            left = null;
            right = null;
        }

        public Node(Customer data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public Customer Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
