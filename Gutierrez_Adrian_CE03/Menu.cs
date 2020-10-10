// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;
namespace Gutierrez_Adrian_CE03
{
    class Menu : MenuController
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
                Console.WriteLine(menuOption);
                i++;
            }
        }

    }
}
