// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
{
    public class Course
    {
        // Can you please help me by leaving me feedback in FSO after grading. I am writing here so I dont forget ...
        // ... Thanks! :)


        // Question 1 - What is the point of using fields in the way that i have them, if an auto (or regular) property ...
        // ... replaces them perfectly? (Instructions say i must have the fields)

        // Question 2 - I understand why you want us to use properties as opposed to public fields, (for future ease of change) ...
        // but why would i keep the field and how would i protect it if its being mutated anyway?



        // Contains the following fields
        // a string for the course title
        private string _title;
        // a string for the course description
        private string _descr;
        // a Teacher for the teacher assigned to the course
        // I am leaving this as a private field becasue the instructions say to leave this as a field and you say you dont ...
        // ... like fields to be public so I created a property.
        private Teacher _teacher;
        // a Student array for the students in the course
        private Student[] _students;

        // Properties
        // This property basically 'replaces' a public field so I dont understand why I am 'keeping' the field other than simply ...
        // ... following intsructions.
        public Teacher Teacher { get { return _teacher; } set { _teacher = value; } }
        // Same for Students
        public Student[] Students { get { return _students; } set { _students = value; } }
        public string Title { get { return _title; } }
        public string Desc { get { return _descr; } }

        // Constructor
        // The constructor uses parameters to fill out the title, description, and the number of students.
        public Course(string title, string descr, int studNum)
        {
            _title = title;
            _descr = descr;

            // The number of students should be used to create the array to be held in the Student array field.
            // It is expected the Student array will contain null references until the appropriate menu option ...
            // ... has been selected by the user.
            _students = new Student[studNum];
        }
    }
}
