// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;
using System.Collections.Generic;

namespace Gutierrez_Adrian_CE03
{
    public class Application
    {
        // Variables
        // MainMenu string array
        public string[] _mainMenuArray = {"Add Employee", "Remove Employee", "DisplayPayroll", "Exit" };
        // MainMenu menu object
        private Menu _mainMenuObj;
        // List of Employees
        private List<Employee> _employees = new List<Employee>();
        // bool to run/close program loop
        private bool _run = true;
        // User's selection
        private string _userSelection;

        // Constructor
        public Application()
        {
            // Instantiating Main Menu
            _mainMenuObj = new Menu(_mainMenuArray);

            // The program will run until exited
            while (_run)
            {
                UI.Header("Main Menu");
                _mainMenuObj.DisplayMenu();

                // - Selections can be make using an index 1,2,3 or by typing the associated string like “add employee”.
                // I will go with the strings this time since i did the numeric way in CE02.
                _userSelection = Validate.MenuSelection("Type your selection", _mainMenuObj.MenuOptions);

                // Checking to see if the program should exit before any further computing
                if (_userSelection == "exit")
                {
                    _run = false;
                } else
                {
                    // Will place call for switch and case here
                    // Temp Write Line
                    Console.WriteLine("You selected: " + _userSelection);
                    Console.ReadKey();
                }

            }



        } // End Constructor










    } // End Class
}
