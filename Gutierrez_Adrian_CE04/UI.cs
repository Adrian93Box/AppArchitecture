// Adrian Gutierrez
// Oct 14, 2020
// APA
// 3.3 Code Exercise: Interfaces

using System;
namespace Gutierrez_Adrian_CE04
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


        
    }
}
