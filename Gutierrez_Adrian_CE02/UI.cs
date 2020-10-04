// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
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

    }
}
