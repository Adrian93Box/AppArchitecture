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
            // Instantiating Main Menu
            Menu mainMenu = new Menu(_mainMenuArray);

            // The program will run until exited
            while (_run)
            {
                // Load employees from txt file entitled: employees.txt in the output folder for this project
                Load();

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
                    _employees = mainMenu.MainMenuOperator(_userSelection, _employees);
                    Save();
                }

            }



        } // End Constructor






        // The following method will load all employees from the txt file and save them into '_employees'
        // This load function is smart enough to detemine the difference between Fulltime, Parttime, and Manager employees
        private static void Load()
        {
            // - The text file should be checked if it exists and then loaded when the assignment executes.
            if (File.Exists(_ioPath))
            {
                // Variables
                Employee employee;


                using (StreamReader sr = new StreamReader(_ioPath))
                {
                    string line;
                    string[] lineSplit;

                    // This loop will continue until all employees are added into the list: '_employees'
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Spliting line at '|' and saving seperate string into a temp string array
                        lineSplit = line.Split('|');

                        // The following conditional will run through all employees in the employees.txt and load them according to their ...
                        // ... types. (Fulltime, PartTime, and Manager)

                        // Differentiating between manager and hourly
                        if (decimal.Parse(lineSplit[3]) != 0)
                        {

                            // Differentiating between Fulltime and Parttime
                            if (decimal.Parse(lineSplit[3]) < 40)
                            {
                                // Creating a Parttime employee with newly obtained info
                                // (The info will be validated before being saved, therefore no need for further validation)
                                employee = new PartTime(lineSplit[0], lineSplit[1], decimal.Parse(lineSplit[2]), decimal.Parse(lineSplit[3]));

                                // Adding employee to list: '_employees'
                                _employees.Add(employee);
                            }
                            else
                            {
                                // Creating a Fulltime employee with newly obtained info
                                // (The info will be validated before being saved, therefore no need for further validation)
                                employee = new FullTime(lineSplit[0], lineSplit[1], decimal.Parse(lineSplit[2]), decimal.Parse(lineSplit[3]));

                                // Adding employee to list: '_employees'
                                _employees.Add(employee);
                            }

                        } else
                        {
                            // Creating a Manager employee with newly obtained info
                            // (The info will be validated before being saved, therefore no need for further validation)
                            employee = new Manager(lineSplit[0], lineSplit[1], decimal.Parse(lineSplit[4]), decimal.Parse(lineSplit[5]));

                            // Adding employee to list: '_employees'
                            _employees.Add(employee);
                        }


                        
                    }

                    // FOR PROGRESS CHECK ONLY
                    UI.Alert($"You have succesfully loaded employees from your txt file in path: {_ioPath}");
                    foreach (Employee emp in _employees)
                    {
                        Console.WriteLine(emp.Name);
                    }
                    UI.Footer("Press any key to continue");
                    // END OF PROGRESS CHECK

                }
            } else
            {
                UI.Alert("(Error) Your path file does not exist. No data was uploaded!");
                UI.Footer("Press any key to continue");
            }
        }





        // Save _employees to the txt file int the output folder entitled 'employees.txt'
        // This save function is smart enough to detemine the difference between Fulltime, Parttime, and Manager employees
        public static void Save()
        {
            // validating the file exists
            if (File.Exists(_ioPath))
            {

                // Stream writer used for writing new content
                using (StreamWriter sw = new StreamWriter(_ioPath))
                {

                    // The following loop will loop through all employees in the list '_employees' and save them according to their ...
                    // ... types. (Fulltime, PartTime, and Manager)
                    foreach(Employee employee in _employees)
                    {
                        if (employee is Hourly)
                        {
                            sw.WriteLine($"{employee.Name}|{employee.Address}|{((Hourly)employee).PayPerHour}|{((Hourly)employee).HoursPerWeek}|0|0");

                            // TESTING PURPOSES
                            if (((Hourly)employee).HoursPerWeek < 40)
                            {
                                UI.Alert("A part time employee was saved!");
                                UI.Footer("Press any key to continue");
                            } else
                            {
                                UI.Alert("An full time employee was saved!");
                                UI.Footer("Press any key to continue");
                            }


                        } else if (employee is Manager)
                        {
                            sw.WriteLine($"{employee.Name}|{employee.Address}|0|0|{((Manager)employee).Salary}|{((Manager)employee).Bonus}");

                            // TESTING PURPOSES
                            UI.Alert("A Manager employee was saved!");
                            UI.Footer("Press any key to continue");
                        } else
                        {
                            UI.Alert("(Error) An employee type was unrecognised! Could not save this type!");
                            UI.Footer("Press any key to continue");
                        }
                    }

                    // FOR PROGRESS CHECK ONLY
                    UI.Alert($"You have succesfully saved employees to your txt file in path: {_ioPath}");
                    Console.ReadKey();
                }


            } else
            {
                UI.Alert("(Error) Your path file does not exist. No data was saved!");
                UI.Footer("Press any key to continue");
            }
        }

    } // End Class
}
