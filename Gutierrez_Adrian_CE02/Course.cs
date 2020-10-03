// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
{
    public class Course
    {
        // Contains the following fields
        // a string for the course title
        private string _title;
        // a string for the course description
        private string _descr;
        // a Teacher for the teacher assigned to the course
        private Teacher _teacher;
        // a Student array for the students in the course
        private Student[] _students;

        // Constructor
        // The constructor uses parameters to fill out the title, description, and the number of students.
        public Course(string title, string descr, Teacher teacher, int studNum)
        {
            _title = title;
            _descr = descr;
            _teacher = teacher;

            // The number of students should be used to create the array to be held in the Student array field.
            // It is expected the Student array will contain null references until the appropriate menu option ...
            // ... has been selected by the user.

            // (Code Here)
        }
    }
}
