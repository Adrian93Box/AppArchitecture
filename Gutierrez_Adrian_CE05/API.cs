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
        // Constructor needed for APIFramework
        public API(string url) : base(url) { }


        // Gets title from json
        public string GetTitle()
        {
            dynamic json = GetJSON();

            return json.Title;
        }

        // Gets release year from json
        public string GetYear()
        {
            dynamic json = GetJSON();

            return json.Year;
        }

        // Gets rating from json
        public string GetRating()
        {
            dynamic json = GetJSON();

            return json.Rated;
        }

        // Gets genre from json
        public string GetGenre()
        {
            dynamic json = GetJSON();

            return json.Genre;
        }

        // Gets director from json
        public string GetDirector()
        {
            dynamic json = GetJSON();

            return json.Director;
        }

        // Gets plot from json
        public string GetPlot()
        {
            dynamic json = GetJSON();

            return json.Plot;
        }
    }
}
