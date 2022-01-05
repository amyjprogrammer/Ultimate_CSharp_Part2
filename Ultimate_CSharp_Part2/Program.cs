using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_CSharp_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "John";
            person.Introduce("Amy");

            //using static and not having to new up a Person everytime

            var personOne = Person.Parse("John");
            personOne.Introduce("Amy"); //gets the same thing as the three lines of code above

            var customer = new Customer();
            Console.WriteLine(customer.Name);//default null
            Console.WriteLine(customer.CustomerId);//default 0

            var cust = new Customer("John", 1);
            Console.WriteLine($"{cust.Name} is Customer {cust.CustomerId}");

            var human = new Human();
            human.SetBirthDate(new DateTime(1982, 1, 1));
            Console.WriteLine(human.GetBirthdate());

            var per = new Person();
            per.Birthdate = new DateTime(1982, 1, 1);
            Console.WriteLine(per.Age);

            var cookie = new HttpCookie();
            cookie["name"] = "Amy";
            Console.WriteLine(cookie["name"]);
        }
    }
}
