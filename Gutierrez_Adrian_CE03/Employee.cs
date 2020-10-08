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

        // - Employee needs a constructor that takes parameters for name and address
        public Employee(string name, string address)
        {
            _name = name;
            _address = address;
        }


        // - Employee must contain a virtual method CalculatePay
        protected virtual decimal CalcPay(decimal pph, decimal hpw)
        {
            decimal weeksPerYear = 52;

            // Calculating pay for an entire year. Multiplying weekly pay by the amount of ...
            // ... weeks in a year.
            // (This will work only for Hourly type Employees)
            decimal pay = (pph * hpw) * weeksPerYear;

            return pay;
        }

    }
}
