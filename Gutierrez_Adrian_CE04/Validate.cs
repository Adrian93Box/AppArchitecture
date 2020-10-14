// Adrian Gutierrez
// Oct 14, 2020
// APA
// 3.3 Code Exercise: Interfaces

using System;
namespace Gutierrez_Adrian_CE04
{
    public static class Validate
    {
        // Validate that the user typed in a string and return the validated string.
        public static string String(string message)
        {
            UI.Prompt(message);
            string userInput = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userInput))
            {
                UI.Alert("You may not leave this blank!");
                UI.Prompt(message);
                userInput = Console.ReadLine();
            }

            return userInput;
        }



        // Range of numbers the user may choose from, returns the number
        public static int Range(string message, int min, int max)
        {
            UI.Prompt(message);
            string response = Console.ReadLine();
            int responseInt;

            // Validating selection
            while (!int.TryParse(response, out responseInt) || responseInt < min || responseInt > max)
            {
                UI.Alert($"You did not enter a valid number between {min} and {max}!");
                UI.Prompt(message);
                response = Console.ReadLine();
            }

            return responseInt;
        }

    }
}
