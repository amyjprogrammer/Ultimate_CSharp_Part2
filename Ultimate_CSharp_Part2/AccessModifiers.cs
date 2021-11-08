using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_CSharp_Part2
{
    class AccessModifiers
    {
        //five types- public, private, protected, internal and protected internal

        //object-oriented programming
        //encapsulation/ information hiding
        //inheritance
        //polymorphism


    }

    public class Human
    {
        private string _name; //this is a hidden field

        private DateTime _birthdate; 

        public void SetName(string name)
        {
            if (!String.IsNullOrEmpty(name))
                this._name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}
