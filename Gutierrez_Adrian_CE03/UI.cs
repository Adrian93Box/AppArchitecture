// Adrian Gutierrez
// 10/07/2020
// APA
// 2.3 Code Exercise: Polymorphism


using System;

namespace Gutierrez_Adrian_CE03
{
    public static class UI
    {
        // Header for the Menu
        public static void Header(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===============================================\n");
        }




        // Seperator for consistancy
        public static void Separator()
        {
            Console.WriteLine("\n-------------------------------");
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
            Console.WriteLine($"ALERT - {message}");
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }




        // Footer
        public static void Footer(string message)
        {
            Console.WriteLine("\n===============================================");
            Console.Write(message + " _");
            Console.ReadKey();
        }

    }
}
