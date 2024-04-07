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
    public partial class Form1 : Form{

        CustomerTree tree = new CustomerTree();
        public Form1(){
            InitializeComponent();
        }

        private void updateCount() {
            countBox.Text = tree.Count().ToString();
        }

        private void addButton_Click(object sender, EventArgs e){
            Customer customer = new Customer(nameBox.Text, addressBox.Text, Convert.ToInt32(ageBox.Text), Convert.ToInt32(amountBox.Text));
            tree.InsertItem(customer);
            updateCount();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e){

        }

        private void inOrderButton_Click(object sender, EventArgs e){
            customerBox.Items.Clear();
            String[] result = tree.InOrder();
            foreach (String s in result){
                customerBox.Items.Add(s);
            }
        }

        private void preOrderButton_Click(object sender, EventArgs e){
            customerBox.Items.Clear();
            String[] result = tree.PreOrder();
            foreach (String s in result) { 
                customerBox.Items.Add(s);
            }
        }

        private void postOrderButton_Click(object sender, EventArgs e){
            customerBox.Items.Clear();
            String[] result = tree.PostOrder();
            foreach (String s in result) {
                customerBox.Items.Add(s);
            }
        }

        private void searchButton_Click(object sender, EventArgs e){
            String name = searchTextBox.Text;
            Customer customer = tree.FindItem(name);
            resultTextBox.Text = customer.getInformation(); 
        }
    }
}
