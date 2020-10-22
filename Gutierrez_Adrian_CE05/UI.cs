// Adrian Gutierrez
// 10/21/2020
// APA
// 4.3 Code Exercise: API Application



// This class holds all of the user interface setup for the application

using System;
namespace Gutierrez_Adrian_CE05
{
    public static class UI
    {

        // The header for the application view
        public static void Header(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==================================");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($" {title}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==================================\n");
            Console.ForegroundColor = ConsoleColor.White;
        }


        // Seperator for consistancy
        public static void Separator()
        {
            Console.WriteLine("-------------------------------");
        }


        // Prompt formatting
        public static void Prompt(string message)
        {
            Console.WriteLine("\n-------------------------------");
            Console.Write($"{message} _");
        }


        // Alert formating for consistancy
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"ERROR - {message}");
            Console.WriteLine("-------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
