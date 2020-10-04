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

        // Properties
        public string Name { get { return _name; } }
        public string Descr { get { return _descr; } }
        public int Age { get { return _age; } }

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
