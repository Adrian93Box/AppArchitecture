// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;
namespace Gutierrez_Adrian_CE03
{
    public class Menu : Application
    {
        // This Menu is simply an array of strings. It takes in an array of strings and has a ...
        // ... method to display them one by one.

        // Menu String Array holding options making this Menu class as reusable as possible
        private static string[] _menuOptions;

        // Holds how many items/options this Menu has to select from. (Private for now)
        private int menuItemsCount;

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
