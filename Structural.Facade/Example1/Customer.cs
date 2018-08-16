using System;
using System.Collections.Generic;
using System.Text;

namespace Structural.Facade.Example1
{
    class Customer
    {
        private string _name;

        // Constructor

        public Customer(string name)
        {
            this._name = name;
        }

        // Gets the name

        public string Name
        {
            get { return _name; }
        }
    }
}
