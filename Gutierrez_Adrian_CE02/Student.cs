// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
{
    // Inherits from Person
    public class Student : Person
    {
        // Contains the following fields
        // An integer for the Student’s grade
        private int _grade;

        // Adding a Property
        public int Grade { get { return _grade; } }

        // Constructor
        // The constructor uses a parameter to fill the grade field in the class
        // This constructor can take other parameters as well ...
        // ... Think about the base/parent class constructor.
        public Student(string name, string descr, int age, int grade) : base (name, descr, age)
        {
            _grade = grade;

        }
    }
}
