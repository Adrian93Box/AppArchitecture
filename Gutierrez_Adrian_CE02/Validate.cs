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
        // This method will then return the number that will match the chosen Menu option.
        public static int MenuSelection(string message, int optCount)
        {
            // Prompt user for selection
            Console.Write(message + " _");

            // Retrieving user's typed response
            int.TryParse(Console.ReadLine(), out int userSelection);

            // - The menu must handle the user typing the text of a selection or the number
            // -- Input should be handled in a case insensitive format
            // I went with number. (More effecient given the minor processing power and less code)
            while (userSelection < 1 || userSelection > optCount)
            {
                UI.Separator();
                // Prompt Alert
                Console.Write($"You must enter a number from 1 and {optCount}! _");
                UI.Separator();
                // Retrieving user's typed response
                int.TryParse(Console.ReadLine(), out userSelection);
            }

            // Returning the number matching the Menu Option
            return userSelection;
        }







        // The following Method accepts a message for prompt and will return a validated string that is not empty
        public static string HoldsText(string message)
        {
            Console.Write(message + " _");
            string input = Console.ReadLine();

            // Validating loop will continue to prompt user until the input holds value
            while (string.IsNullOrWhiteSpace(input))
            {
                UI.Separator();
                Console.WriteLine("-!-You must not leave this blank!");
                UI.Separator();
                Console.Write(message + " _");
                input = Console.ReadLine();
            }

            return input;
        }







        // This method takes in a message to be prompted and returns the user's validated numeric response ...
        // ... greater than 0.
        public static int IsNumber(string message)
        {
            // Variable
            int inputInt;

            Console.Write(message + " _");
            string input = Console.ReadLine();

            // Validating loop will continue to prompt user until the input holds a number greater than 0
            while (!int.TryParse(input, out inputInt) || inputInt < 1)
            {
                UI.Separator();
                Console.WriteLine("-!-You must enter a number greater than 0");
                UI.Separator();
                Console.Write(message + " _");
                input = Console.ReadLine();
            }

            return inputInt;
        }






        // This method takes in a message to be prompted and returns an array holding 3 education topics
        // This method also feeds off from the 'Validate.HoldsText' and the 'Validate.IsNumber' methods above.
        public static string[] StringArray(string message, string arrayOf)
        {
            UI.Separator();

            // Prompting user
            Console.WriteLine(message);

            // Prompting for how many items in the string array to create
            int items = Validate.IsNumber($"How many {arrayOf} to enter:");

            // Variables
            // ATTENTION TO INSTRUCTOR
            // For some reason adding plus 1 fixed the crash i was getting without it, however, i don't understand why ...
            // ... what i understand is that the number in the given '[]' should be how many items the array holds ...
            // ... So if one types '3' for example, it should hold three items in index's: 0, 1, and 2 ... 
            string[] educationTopics = new string[items + 1];

            UI.Separator();
            // This loop will lopp three times creating three strings for string array
            for (int i = 1; i <= items; i++)
            {
                // Validating user reponse
                educationTopics[i] = Validate.HoldsText($"{arrayOf} {i} of {items}:");
            }

            // returning an array of strings
            return educationTopics;
        }






    }
}
