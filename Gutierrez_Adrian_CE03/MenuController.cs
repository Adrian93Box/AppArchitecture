// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism

// This Class holds all of the info and computing for all menus in this program.
// Operator methods will operate their corresponding menus; They will be named after them.


using System;
using System.Collections.Generic;

namespace Gutierrez_Adrian_CE03
{
    abstract class MenuController
    {
        // Operators

        // Operator for MainMenu
        public List<Employee> MainMenuOperator(string userSelection, List<Employee> employees)
        {
            switch (userSelection)
            {
                case "add employee":
                    employees = AddEmployee(employees);
                    break;
                case "remove employee":
                    RemoveEmployee();
                    break;
                case "display payroll":
                    DisplayPayroll();
                    break;
            }

            return employees;
        }





        /// ///////////////////////////
        // Each method below will run the neccesary code to run the menu selection it is named after
        /// ///////////////////////////


        // Add Employee
        public List<Employee> AddEmployee(List<Employee> employees)
        {



            return employees;
        }





        public void RemoveEmployee()
        {

        }





        public void DisplayPayroll()
        {

        }



    }
}
