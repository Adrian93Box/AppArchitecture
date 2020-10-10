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







        // Validate that the user typed in a string and return the validated string.
        public static string String(string message)
        {
            Console.Write(message + " _");
            string userInput = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userInput))
            {
                UI.Alert("You may not leave this blank!");
                Console.Write(message + " _");
                userInput = Console.ReadLine();
            }

            return userInput;
        }






        // Validate that the user typed in a number and return the validated decimal.
        // Accepts a message for instructions and an int for the minimum amount alowed.
        public static decimal Decimal(string message, int min)
        {
            // Variable
            decimal userInputInt;

            Console.Write(message + " _");
            string userInput = Console.ReadLine();

            while (!decimal.TryParse(userInput, out userInputInt) || userInputInt < min)
            {
                UI.Alert($"You did not enter a valid number equal to or greater than {min}!");
                Console.Write(message + " _");
                userInput = Console.ReadLine();
            }

            return userInputInt;
        }

    }
}
