// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
{
    public static class Validate
    {


        // Validate that the user has selected one of the list of provided options
        // This method will require a 'Message' to prompt the user for input, and an int resembling the ...
        // ... 'Amount of Menu Options' in the Menu the user is being prompted to choose from.
        // This method will then return the number that will match the 'index' in the array that holds the Menu options.
        public static int MenuSelection(string message, int optCount)
        {
            // Prompt user for selection
            Console.WriteLine(message);

            // Retrieving user's typed response
            int.TryParse(Console.ReadLine(), out int userSelection);

            // - The menu must handle the user typing the text of a selection or the number
            // -- Input should be handled in a case insensitive format
            // I went with number. (More effecient given the minor processing power and less code)
            while (userSelection < 1 || userSelection > optCount)
            {
                // Prompt Alert
                Console.WriteLine($"You must enter a number from 1 and {optCount}!");
                // Retrieving user's typed response
                int.TryParse(Console.ReadLine(), out userSelection);
            }

            // Returning the number resembling where the selected menu option lies in the given array's index
            return userSelection - 1;
        }
    }
}
