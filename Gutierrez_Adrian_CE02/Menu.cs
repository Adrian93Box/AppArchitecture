// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
{
    // (Remember that the Menu class should be as reusable as possible)  These requirements are highlighting ...
    // ... what should show to the user, not the functionality that should be within the Menu class.

    public class Menu : Application
    {
        // Menu String Array holding options making this Menu class as reusable as possible
        private static string[] _menuOptions;
        public int menuItemsCount;

        // Constructor
        public Menu(string[] menuOptions)
        {
            _menuOptions = menuOptions;
            menuItemsCount = _menuOptions.Length;
        }


        // Display Menu options
        public void DisplayMenu()
        {
            int i = 1;
            foreach (string menuOption in _menuOptions)
            {
                Console.WriteLine($"[{i}] {menuOption}");
                i++;
            }
        }

    }
}
