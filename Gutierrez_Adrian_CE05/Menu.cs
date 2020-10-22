// Adrian Gutierrez
// 10/21/2020
// APA
// 4.3 Code Exercise: API Application



// This class creates an object that holds the setup required for creating and displaying a menu

using System;
namespace Gutierrez_Adrian_CE05
{
    public class Menu
    {
        public string[] MenuOptions { get; set; }


        // Constructor
        public Menu(string[] menuOptions)
        {
            MenuOptions = menuOptions;
        }


        // Display Menu options
        public void DisplayMenu()
        {
            int i = 1;
            foreach (string menuOption in MenuOptions)
            {
                Console.WriteLine($"[{i}] " + menuOption);
                i++;
            }
        }
    }
}
