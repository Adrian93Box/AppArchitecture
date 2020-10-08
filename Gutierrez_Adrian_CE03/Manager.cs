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

        // - Manager needs a constructor that takes name, address, salary, and bonus.
        public Manager(string name, string address, decimal salary, decimal bonus) : base (name, address, salary)
        {
            _bonus = bonus;
        }

        // Overriding CalcPay as this will not work the same for a Manager as it does for an hourly Employee
        protected override decimal CalcPay(decimal salary, decimal bonus)
        {
            return salary + bonus;
        }
    }
}
