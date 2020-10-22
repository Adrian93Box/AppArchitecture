// Adrian Gutierrez
// 10/21/2020
// APA
// 4.3 Code Exercise: API Application



// This class holds the framework for pulling API json data

using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Gutierrez_Adrian_CE05
{
    abstract class APIFramework
    {
        // Fields
        private string _url;
        
        // Constructor
        public APIFramework(string url)
        {
            _url = url;
        }


        // Getting parsed json from the api
        public dynamic GetJSON()
        {
            // Fields
            string jsonString;
            dynamic json;

            // Using a temperary object to pull date from an api
            using (WebClient wc = new WebClient())
            {
                // Getting the string json from the url
                jsonString = wc.DownloadString(_url);

                // assigning the object to hold the parsed json taken from the json string
                json = JObject.Parse(jsonString);
            }

            return json;
        }


        // Gets title from json
        protected string GetTitle(dynamic json)
        {
            return json.Title;
        }

        // Gets release year from json
        protected string GetYear(dynamic json)
        {
            return json.Year;
        }

        // Gets rating from json
        protected string GetRating(dynamic json)
        {
            return json.Rated;
        }

        // Gets genre from json
        protected string GetGenre(dynamic json)
        {
            return json.Genre;
        }

        // Gets director from json
        protected string GetDirector(dynamic json)
        {
            return json.Director;
        }

        // Gets plot from json
        protected string GetPlot(dynamic json)
        {
            return json.Plot;
        }
    }
}
