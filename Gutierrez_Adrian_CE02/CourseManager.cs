// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
{
    // - CourseManager Class - This class will hold the code controlling most of your application ...
    // ... (to Program)
    public class CourseManager
    {
        // Variables

        // - Before anything else you will need a Course variable to use for the currentCourse.
        // Private field holding the newly created Course
        private Course _currentCourse;
        // Menu for main. 
        private string[] _mainMenuArray = { "Create Course","Create Teacher","Add Students","Display", "Exit" };

        

        // Constructor
        public CourseManager()
        {
            // Variables
            Menu mainMenu = new Menu(_mainMenuArray);
            // A boolean that will continue true until the user decides to exit
            bool run = true;

            // - Program should run until the user chooses to exit.
            while (run)
            {
                // Setting up header
                UI.Header("Course Tracker");

                // Display Main Menu
                mainMenu.DisplayMenu();

                // Prompting user for input then saving the response
                int menuItemSelection = Validate.MenuSelection($"Please enter your selection [1] - [{mainMenu.menuItemsCount}]",
                    mainMenu.menuItemsCount + 1);

                Console.Clear();
                // Running a switch and case to control Menu options
                switch (menuItemSelection)
                {
                    case 1:
                        _currentCourse = mainMenu.CreateCourse();
                        break;
                    case 2:
                        // Validating that the course has already been created
                        if (_currentCourse != null)
                        {
                            _currentCourse = mainMenu.CreateTeacher(_currentCourse);
                        } else
                        {
                            Console.WriteLine("You must first Create a Course!");
                            UI.Separator();
                            Console.Write("Press any key to Return to Main Menu: _");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        // Validating that the course has already been created
                        if (_currentCourse != null)
                        {
                            _currentCourse = mainMenu.AddStudent(_currentCourse);
                        }
                        else
                        {
                            Console.WriteLine("You must first Create a Course!");
                            UI.Separator();
                            Console.Write("Press any key to Return to Main Menu: _");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        // Validating that the course has already been created
                        if (_currentCourse != null)
                        {
                            // Validating that the course contains all neccessary info to display
                            if (_currentCourse.Teacher == null || _currentCourse.Students[0] == null)
                            {
                                Console.WriteLine("You must first enter a Teacher and Students to see Course info!");
                                UI.Separator();
                                Console.Write("Press any key to Return to Main Menu: _");
                                Console.ReadKey();
                            } else
                            {
                                mainMenu.Display(_currentCourse);
                            }
                            
                        }
                        else 
                        {
                            Console.WriteLine("You must first Create a Course!");
                            UI.Separator();
                            Console.Write("Press any key to Return to Main Menu: _");
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        run = false;
                        break;
                    default:
                        UI.Separator();
                        Console.WriteLine("Error - Issue with 'int selection' in MenuControllers.MainMenu");
                        break;
                }

            } // End of While Loop

        } // End of CoureManager Constructor
    }
}
