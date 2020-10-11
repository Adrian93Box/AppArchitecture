// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;
namespace Gutierrez_Adrian_CE03
{
    // - Manager will inherit from Salaried ...
    class Manager : Salaried
    {
        // - ...  with a decimal field for bonus.
        private decimal _bonus;

        // Properties
        public decimal Bonus { get { return _bonus; } }

        // - Manager needs a constructor that takes name, address, salary, and bonus.
        public Manager(string name, string address, decimal salary, decimal bonus) : base (name, address, salary)
        {
            _bonus = bonus;
        }

        // Overriding CalcPay from the Employee class
        public override decimal CalcPay()
        {
            return _salary + _bonus;
        }
    }
}
