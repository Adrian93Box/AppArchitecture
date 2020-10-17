// Adrian Gutierrez
// Oct 14, 2020
// APA
// 3.3 Code Exercise: Interfaces

using System;
using System.Collections.Generic;

namespace Gutierrez_Adrian_CE04
{
    public static class Validate
    {
        // Validate that the user typed in a string and return the validated string.
        public static string String(string message)
        {
            UI.Prompt(message);
            string userInput = Console.ReadLine().ToLower();

            while (string.IsNullOrWhiteSpace(userInput))
            {
                UI.Alert("You may not leave this blank!");
                UI.Prompt(message);
                userInput = Console.ReadLine().ToLower();
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


        // Takes in a dictionary then prompts and loops until the user enters an existing key
        public static string Key(string message, Dictionary<string, string> dictionary)
        {
            UI.Prompt(message);
            string signal = Console.ReadLine().ToLower();

            // Checking to see if the user has entered an existing signal (key)
            // The key was created using the String validation method, this method enforces a lowercase string therefore
            // no need to lower the casing in the conditional
            while (!dictionary.ContainsKey(signal))
            {
                UI.Alert("This signal does not exist!");
                UI.Prompt(message);
                signal = Console.ReadLine().ToLower();
            }

            // Once the key is entered correctly, it is returned
            return signal;
        }



    }
}
