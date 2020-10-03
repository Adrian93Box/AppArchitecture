// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
{
    // Inherits from Person
    public class Teacher : Person
    {
        // Contains the following field
        // A string array for some piece of information about the teacher ...
        // ... Could be skills they have or something else a teacher would have.
        private string[] _educationTopics;

        // Constructor
        // The constructor uses a parameter to fill the knowledge array in the class
        // This constructor can take other parameters as well ...
        // ... Think about the base/parent class constructor.
        public Teacher(string name, string descr, int age, string[] educationTopics) : base (name, descr, age)
        {
            _educationTopics = educationTopics;
        }
    }
}
