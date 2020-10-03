// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
{
    public class Person
    {
        // Contains the following fields

        // a string for the person’s name.
        private string _name;
        // a string for the person’s description.
        private string _descr;
        // an int for the person’s age.
        private int _age;

        // Constructor
        // Uses parameters to fill out all of its fields with the values entered by the user.
        public Person(string name, string descr, int age)
        {
            _name = name;
            _descr = descr;
            _age = age;
        }
    }
}
