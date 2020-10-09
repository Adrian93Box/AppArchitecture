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
            // ISSUE: Terminal gives very weird output and no errors to find anything wrong. Code looks ...
            // ... perfectly fine as well. Simple and very straight forward.

            // DEBUG: While debugging i tried the below commented out code. The below 'commented out' code will run 'Enter' ...
            // ... everytime you click any key as if it were in a loop 'Enter 2' is never even hit...

            // Console.WriteLine("Enter");
            // Console.ReadKey();

            // Instantiating Main Menu
            _mainMenuObj = new Menu(_mainMenuArray);

            // Console.WriteLine("Enter 2");
            // Console.ReadKey();


            // The program will run until exited
            while (_run)
            {
                UI.Header("Main Menu");
                _mainMenuObj.DisplayMenu();
                UI.Prompt("Enter your selection");
                _userSelection = Console.ReadLine();
                _run = false;
            }



        } // End Constructor










    } // End Class
}
