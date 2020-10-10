// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;
using System.Collections.Generic;
using System.IO;

namespace Gutierrez_Adrian_CE03
{
    public class Application
    {
        // Variables
        // MainMenu string array
        private string[] _mainMenuArray = {"Add Employee", "Remove Employee", "Display Payroll", "Exit" };
        // List of Employees
        private static List<Employee> _employees = new List<Employee>();
        // bool to run/close program loop
        private bool _run = true;
        // User's selection
        private string _userSelection;

        // QUESTION : Which is safer/more effecient: to make a private static field? or To pass a private ...
        // ... field through parameters from constructor?

        // Using private static for now since there are no specific requirements
        // File path for IO
        private static string _ioPath = "../../output/employees.txt";

        // Constructor
        public Application()
        {
            // Load employees from txt file entitled: employees.txt in the output folder for this project
            Load();

            // Instantiating Main Menu
            Menu mainMenu = new Menu(_mainMenuArray);

            // The program will run until exited
            while (_run)
            {
                UI.Header("Main Menu");
                mainMenu.DisplayMenu();

                // - Selections can be make using an index 1,2,3 or by typing the associated string like “add employee”.
                // I will go with the strings this time since i did the numeric way in CE02.
                _userSelection = Validate.MenuSelection("Type your selection", mainMenu.MenuOptions);

                // Checking to see if the program should exit before any further computing
                if (_userSelection == "exit")
                {
                    _run = false;
                } else
                {
                    // Running the operator for Main Menu
                    mainMenu.MainMenuOperator(_userSelection, _employees);
                }

            }



        } // End Constructor






        // The following method will load all employees from the txt file and save them into '_employees'
        private static void Load()
        {
            // - The text file should be checked if it exists and then loaded when the assignment executes.
            if (File.Exists(_ioPath))
            {
                // Variables
                FullTime employee;


                using (StreamReader sr = new StreamReader(_ioPath))
                {
                    string line;
                    string[] lineSplit;

                    // This loop will continue until all employees are added into the list: '_employees'
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Spliting line at '|' and saving seperate string into a temp string array
                        lineSplit = line.Split('|');

                        // Creating a full time employee with newly obtained info
                        // (The info will be validated before being saved, therefore no need for further validation)
                        employee = new FullTime(lineSplit[0], lineSplit[1], decimal.Parse(lineSplit[2]), decimal.Parse(lineSplit[3]));

                        // Adding employee to list: '_employees'
                        _employees.Add(employee);
                    }

                    // FOR PROGRESS CHECK ONLY
                    UI.Alert($"You have succesfully added employees from your txt file in path: {_ioPath}");
                    foreach (Employee emp in _employees)
                    {
                        Console.WriteLine(emp.Name);
                    }
                    UI.Separator();


                }
            } else
            {
                UI.Alert("Your path file does not exist. No data was uploaded!");
            }
        }



    } // End Class
}
