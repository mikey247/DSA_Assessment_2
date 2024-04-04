using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_2_Solution
{
    internal class Customer: IComparable{
      

        public string name;
        public string address;
        public string phone;

        public Customer(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public int CompareTo(object obj){
            return name.CompareTo(((Customer)obj).name);
        }

        public void getInformation(){
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Phone: " + phone);
        }

    }
}
