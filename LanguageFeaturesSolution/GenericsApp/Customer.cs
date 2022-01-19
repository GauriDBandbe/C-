using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    public class Customer : IComparable<Customer>
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public String Address { get; set; }
        public int Age { get; set; }
        public Customer(int cid, string cn, string addr, int age)
        {
            CustomerID = cid;
            CustomerName = cn;
            Address = addr;
            Age = age;

        }

        public int CompareTo(Customer other)
        {
            return this.Age.CompareTo(other.Age);
        }
        public override string ToString()
        {
            return String.Format($"Custoer ID: {CustomerID} , Name: {CustomerName}, Address: {Address}, Age: {Age}");
        }
    }
}
