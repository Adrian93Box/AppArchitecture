// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;
namespace Gutierrez_Adrian_CE03
{
    // - FullTime will inherit from Hourly.
    class FullTime : Hourly
    {
        // - FullTime needs a constructor that takes parameters for name, address, and payPerHour.
        public FullTime(string name, string address, decimal pph, decimal hpw = 40) : base ( name, address, pph, hpw)
        {
        }
    }
}
