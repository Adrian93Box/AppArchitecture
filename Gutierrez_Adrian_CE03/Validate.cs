// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;

namespace Gutierrez_Adrian_CE03
{
    public static class Validate
    {
        // The following method will take in an array of strings and will validate that the user has ...
        // ... entered a matching selection. It will then return the selection in string format.
        public static string MenuSelection(string message, string[] menuSelections)
        {
            // Variables
            string userSelection;

            // This loop will run until the user types a valid selection
            while (true)
            {
                UI.Prompt(message);

                // The following code will create a lowercase version of the user's input and save it into 'userSelection'
                userSelection = Console.ReadLine().ToLower();

                // The following loop will compare the user's selection with the menu's selections
                foreach (string selection in menuSelections)
                {
                    // If the userSelection matches, the loop will close and return the user's selection
                    if (selection.ToLower() == userSelection)
                    {
                        return userSelection;
                    } 
                }

                // Prompting the user they were not right to enter what was entered.
                UI.Alert("Your entry does not match any menu selections!");
            }
        }


    }
}
