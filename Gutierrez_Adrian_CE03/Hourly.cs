// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;
namespace Gutierrez_Adrian_CE03
{
    // - Hourly will inherit from Employee ...
    class Hourly : Employee
    {
        // - ... and contains decimal fields for payPerHour and hoursPerWeek.
        protected decimal _payPerHour;
        protected decimal _hoursPerWeek;

        // - Hourly needs a constructor that takes parameters for name, address, payPerHour, and hoursPerWeek.
        // -- Name and address need to be passed to the Hourly’s parent constructor.
        public Hourly(string name, string address, decimal pph, decimal hpw) : base ( name, address )
        {
            _payPerHour = pph;
            _hoursPerWeek = hpw;
        }
    }
}
