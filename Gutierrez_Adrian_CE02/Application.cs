// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
{
    public class Application
    {
        // Prompt the user for the information needed to create a new Course object and assign ...
        // ... that object to the currentCourse variable.
        public Course CreateCourse()
        {
            // Header
            UI.Header("Create Course");

            // Commands
            string courseName = Validate.HoldsText("Enter the name of the Course:");
            string courseDescr = Validate.HoldsText("Enter the description for this course:");
            int studentCount = Validate.IsNumber("Please enter the amount of students in the course:");

            // creating Course
            Course course = new Course(courseName, courseDescr, studentCount);

            Console.WriteLine("\nCourse created!");
            Console.Write("Press any key to continue _");
            Console.ReadKey();

            // returning Course
            return course;
        }

        // Prompt the user for the information needed to create a new Teacher object and assign...
        // ...that object to be the currentCourse’s teacher.
        public Course CreateTeacher(Course course)
        {
            // Header
            UI.Header("Create Teacher");

            // Commands
            string name = Validate.HoldsText("Enter name:");
            string description = Validate.HoldsText("Enter description:");
            int age = Validate.IsNumber("Enter Age");
            string[] educationTopics = Validate.StringArray("Please enter the teacher's Education skills.","Education Topics");

            // setting the course's teacher field
            course.Teacher = new Teacher(name, description, age, educationTopics);

            Console.WriteLine("\nTeacher set!");
            Console.Write("Press any key to continue _");
            Console.ReadKey();

            // return course
            return course;
        }

        // Prompt the user for the information needed to create each student.
        // - One for each location in the currentCourse’s Student array.
        public Course AddStudent(Course course)
        {
            // Header
            UI.Header("Add Students");

            // temp array that will be passed into the course object for student array
            Student[] students = new Student[course.Students.Length];

            Console.WriteLine($"You have {students.Length} students to enter");

            // Looping through the length of the students so you can enter them one by one
            // (This number was precoded when the user instantiated the Course object)
            for (int i = 0; i < students.Length; i++)
            {
                // Student number
                UI.Separator();
                Console.WriteLine($"Student {i + 1}");

                // Commands
                string name = Validate.HoldsText("Enter Name:");
                string description = Validate.HoldsText("Enter Description:");
                int age = Validate.IsNumber("Enter Age");
                int grade = Validate.IsNumber("Enter Student Grade:");

                // Adding the entered details into the array of Students
                students[i] = new Student(name, description, age, grade);
            }

            // Setting the Student Array in current course
            course.Students = students;

            Console.WriteLine("\nAll Students Added!");
            Console.Write("Press any key to continue _");
            Console.ReadKey();

            return course;
        }

        // Displays all of the information about the current course.
        // - This includes the teacher and students in the current course.
        public void Display(Course course)
        {
            // Header
            UI.Header("Display Course Info");

            Console.WriteLine("Course:\n");
            Console.WriteLine($"Title: {course.Title}\n");
            Console.WriteLine($"Description: {course.Desc}");

            UI.Separator();
            Console.WriteLine();

            Console.WriteLine("Teacher Info:\n");
            Console.WriteLine($"Name: {course.Teacher.Name}");
            Console.WriteLine($"Description: {course.Teacher.Descr}");
            Console.WriteLine($"Age: {course.Teacher.Age}");
            Console.WriteLine("\nSkills:");
            // displaying all skill
            foreach (string skill in course.Teacher.EducationTopics)
            {
                Console.WriteLine(skill);
            }

            UI.Separator();
            Console.WriteLine();

            foreach (Student student in course.Students)
            {
                Console.WriteLine("Student Info:\n");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Description: {student.Descr}");
                Console.WriteLine($"Age: {student.Age}\n");
                Console.WriteLine($"Grade: {student.Grade}");

                UI.Separator();
            }


            Console.WriteLine("\nAll Info Displayed.");
            Console.Write("Press any key to continue _");
            Console.ReadKey();
        }
    }
}
