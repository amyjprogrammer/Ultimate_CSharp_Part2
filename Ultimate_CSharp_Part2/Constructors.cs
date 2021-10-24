using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_CSharp_Part2
{
    public class Constructors
    {
        //constructor- default
        public Constructors() { }

    }

    public class Customer
    {
        public string Name;
        public int CustomerId;
        public string Email;
        public List<Order> Orders;

        //three constructors with two overloads
        //shortcut for constructors is ctor
        //shortcut to go between classes ctrl + Tab
        public Customer() { }

        public Customer(string name)
        {
            Name = name;
        }

        public Customer(string name, int id)
        {
            Name = name;
            CustomerId = id;
        }

        public Customer(string name, int id, string email)
        {
            Name = name;
            CustomerId = id;
            Email = email;
        }
    }


}
