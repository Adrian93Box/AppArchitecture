// Adrian Gutierrez
// Oct 14, 2020
// APA
// 3.3 Code Exercise: Interfaces

using System;
namespace Gutierrez_Adrian_CE04
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
