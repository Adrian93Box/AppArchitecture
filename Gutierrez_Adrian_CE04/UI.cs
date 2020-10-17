// Adrian Gutierrez
// Oct 14, 2020
// APA
// 3.3 Code Exercise: Interfaces

using System;
namespace Gutierrez_Adrian_CE04
{
    public static class UI
    {
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
        public static void Alert(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"{message}");
            Console.WriteLine("-------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;
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
