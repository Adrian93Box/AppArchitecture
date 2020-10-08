// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;
namespace Gutierrez_Adrian_CE03
{
    // - PartTime will inherit from Hourly.
    class PartTime : Hourly
    {
        public PartTime(string name, string address, decimal pph, decimal hpw) : base( name, address, pph, hpw )
        {

        }
    }
}
