// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism

// This Class holds all of the info and computing for all menus in this program.
// Operator methods will operate their corresponding menus; They will be named after them.


// SIDE NOTE - If i had more time, i would have maybe separated this class into two classes - MenuOperators & MenuFunctions
// OR, maybe create one class for each individual Menu that holds both operators and functions rather than including ...
// ... all menus in one class. (Just a few ideas for better organizing.)


using System;
using System.Collections.Generic;

namespace Gutierrez_Adrian_CE03
{
    abstract class MenuController
    {
        // fields///////////////////////////////////////////
        private string[] _addEmpArray = {"Fulltime","Parttime","Manager"};





        /// /////////////////////////////////////////////////
        // Operators
        /// /////////////////////////////////////////////////

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

        // Operator for Add Employee Menu
        public List<Employee> AddEmpOperator(string userSelection, List<Employee> employees)
        {
            switch (userSelection)
            {
                case "fulltime":
                    FullTime ftEmp = AddFullTimeEmp();
                    employees.Add(ftEmp);
                    UI.Alert($"Full time employee: {ftEmp.Name}, added!");
                    UI.Footer("Press any key to continue:");
                    break;
                case "parttime":
                    PartTime ptEmp = AddPartTimeEmp();
                    employees.Add(ptEmp);
                    UI.Alert($"Part time employee: {ptEmp.Name}, added!");
                    UI.Footer("Press any key to continue:");
                    break;
                case "manager":
                    Manager manager = AddManager();
                    employees.Add(manager);
                    UI.Alert($"Manager: {manager.Name}, added!");
                    UI.Footer("Press any key to continue:");
                    break;
            }

            return employees;
        }








        /// /////////////////////////////////////////////////
        // Each method below will run the neccesary code to run the menu selection it is named after
        /// /////////////////////////////////////////////////



        // Main Menu - Functions///////////////////////////////
        // Add Employee
        public List<Employee> AddEmployee(List<Employee> employees)
        {
            UI.Header("Add Employee");
            // instantiatng a new sub menu
            Menu addEmpMenu = new Menu(_addEmpArray);
            addEmpMenu.DisplayMenu();
            // Validating the user entered a valid selection
            string userSelection = Validate.MenuSelection("Type your selection", addEmpMenu.MenuOptions);
            employees = AddEmpOperator(userSelection, employees);

            return employees;
        }

        // Remove Employee
        public void RemoveEmployee()
        {

        }

        // Display Payroll
        public void DisplayPayroll()
        {

        }







        // Add Employee - Functions///////////////////////////////
        public FullTime AddFullTimeEmp()
        {
            UI.Header("Full Time Employee info");
            string name = Validate.String("Please enter the employee's name:");
            string address = Validate.String($"Please enter {name}'s address:");
            decimal pph = Validate.Decimal($"Please enter {name}'s pay per hour:", 40);
            decimal hpw = Validate.Decimal($"Please enter the amount of hours {name} works per week:", 40);

            FullTime ftEmp = new FullTime(name, address, pph, hpw);

            return ftEmp;
        }

        public PartTime AddPartTimeEmp()
        {
            UI.Header("Part Time Employee info");
            string name = Validate.String("Please enter the employee's name:");
            string address = Validate.String($"Please enter {name}'s address:");
            decimal pph = Validate.Decimal($"Please enter {name}'s pay per hour:", 1);
            decimal hpw = Validate.Decimal($"Please enter the amount of hours {name} works per week:", 1);

            PartTime ptEmp = new PartTime(name, address, pph, hpw);

            return ptEmp;
        }

        public Manager AddManager()
        {
            UI.Header("Manager info");
            string name = Validate.String("Please enter the employee's name:");
            string address = Validate.String($"Please enter {name}'s address:");
            decimal salary = Validate.Decimal($"Please enter {name}'s annual salary:", 20000);
            decimal bonus = Validate.Decimal($"Please enter the amount of bonus {name} will receive:", 1);

            Manager manager = new Manager(name, address, salary, bonus);

            return manager;
        }

    }
}
