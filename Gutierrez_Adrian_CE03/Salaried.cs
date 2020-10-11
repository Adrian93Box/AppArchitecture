// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;
namespace Gutierrez_Adrian_CE03
{
    // - Salaried will inherit from Employee ...
    abstract class Salaried : Employee 
    {
        // - ... and contains a decimal field for salary.
        protected decimal _salary;

        // Properties
        public decimal Salary { get { return _salary; } }

        // - Salaried needs a constructor that takes name, address, and salary
        public Salaried(string name, string address, decimal salary) : base ( name, address )
        {
            _salary = salary;
        }
    }
}
