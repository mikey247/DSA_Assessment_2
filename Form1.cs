using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessed_Exercise_2_Solution
{
    public partial class Form1 : Form
    {
        public Form1(){
            InitializeComponent();

            // Create a new customer
            Customer customer1 = new Customer("John", "1 High Street", "0123456789");
            Customer customer2 = new Customer("Jane", "2 Low Street", "9876543210");
            Customer customer3 = new Customer("Jack", "3 Middle Street", "1234567890");
            Customer customer4 = new Customer("Jill", "4 Left Street", "0987654321");
            Customer customer5 = new Customer("James", "5 Right Street", "1357924680");
            Customer customer6 = new Customer("Jenny", "6 Up Street", "0864213579");
            Customer customer7 = new Customer("Joe", "7 Down Street", "123456789");

            // Create a new node
            Node node1 = new Node(customer1);
            Node node2 = new Node(customer2);
            Node node3 = new Node(customer3);
            Node node4 = new Node(customer4);
            Node node5 = new Node(customer5);
            Node node6 = new Node(customer6);
            Node node7 = new Node(customer7);


            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;

            CustomerTree tree = new CustomerTree(node1); 

            // Display the tree in order
            tree.InOrder();

        }
    }
}
