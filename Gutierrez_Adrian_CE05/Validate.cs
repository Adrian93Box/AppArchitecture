// Adrian Gutierrez
// 10/21/2020
// APA
// 4.3 Code Exercise: API Application


// This class holds all validation methods

using System;
namespace Gutierrez_Adrian_CE05
{
    public static class Validate
    {
        // Range of numbers the user may choose from, returns the number
        public static int Range(string message, int min, int max)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            UI.Prompt(message);
            string response = Console.ReadLine();
            int responseInt;

            // Validating selection
            while (!int.TryParse(response, out responseInt) || responseInt < min || responseInt > max)
            {
                UI.Error($"You did not enter a valid number between {min} and {max}!");
                Console.ForegroundColor = ConsoleColor.Yellow;
                UI.Prompt(message);
                response = Console.ReadLine();
            }

            UI.Separator();
            Console.ForegroundColor = ConsoleColor.White;
            return responseInt;
        }
    }
}
