// Adrian Gutierrez
// 10/21/2020
// APA
// 4.3 Code Exercise: API Application

// This API class is used for returning movie data
// It implements the APIFramework which is what is used to get and parse the api's json

using System;
namespace Gutierrez_Adrian_CE05
{
    class API : APIFramework
    {
        // Field
        private dynamic json;

        // Constructor needed for APIFramework
        public API(string url) : base(url)
        {
            // setting this api's json string to parsed json
            json = GetJSON();
        }


        // Display the API's data on screen (preformatted for console - just run it)
        public void DisplayData()
        {
            Console.Clear();
            UI.Header("API data");
            Console.WriteLine($"Title:\n\n   {GetTitle(json)}\n");
            Console.WriteLine($"Year:\n\n   {GetYear(json)}\n");
            Console.WriteLine($"Genre:\n\n   {GetGenre(json)}\n");
            Console.WriteLine($"Director:\n\n   {GetDirector(json)}\n");
            Console.WriteLine($"Rating:\n\n   {GetRating(json)}\n");
            Console.WriteLine($"Plot:\n\n   {GetPlot(json)}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            UI.Prompt("Press any key to continue:");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
