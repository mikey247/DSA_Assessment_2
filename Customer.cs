using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_2_Solution
{
    internal class Customer: IComparable{


        private string name;
        private int age;
        private string address;
        private float amountOwed;

        public string Name{
            get { return name; }
            set { name = value; }
        }

        public int Age{
            get { return age; }
            set { age = value; }
        }

        public string Address {
            get { return address; }
            set { address = value; }
        }

        public float AmountOwed {
            get { return amountOwed; }
            set { amountOwed = value; }
        }


        public Customer(string name, string address, int age, float amountOwed)
        {
            this.name = name;
            this.address = address;
            this.amountOwed = amountOwed;
        }

        public int CompareTo(object obj){
            return name.CompareTo(((Customer)obj).name);
        }

        public string getInformation(){
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Amount Owed: " + amountOwed);
            return "Name: " + name + " Age: " + age + " Address: " + address + " Amount Owed: " + amountOwed;
        }

    }
}
