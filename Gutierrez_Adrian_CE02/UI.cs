// Adrian Gutierrez
// 10/03/2020
// APA
// CE02 Inheritance



using System;
namespace CE02_Inheritance
{
    public static class UI
    {
        public static void Header(string message)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Course Tracker");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===============================================\n");
        }
    }
}
