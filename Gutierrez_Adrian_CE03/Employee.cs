// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;
namespace Gutierrez_Adrian_CE03
{
    abstract class Employee
    {
        // - Employee will serve as a base class that contains fields for name and address.
        protected string _name;
        protected string _address;

        // Properties
        public string Name { get { return _name; } }
        public string Address { get { return _address; } }

        // - Employee needs a constructor that takes parameters for name and address
        public Employee(string name, string address)
        {
            _name = name;
            _address = address;
        }


        // - Employee must contain a virtual method CalculatePay
        // This method will allow me to call it by using the object 'Employee' but its functionality will only be processed
        // ... through the override methods in its subclasses
        public virtual decimal CalcPay()
        {
            // place holder for the method's return.
            return 0;
        }

    }
}
