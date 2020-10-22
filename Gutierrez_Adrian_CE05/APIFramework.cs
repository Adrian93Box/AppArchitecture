﻿// Adrian Gutierrez
// 10/21/2020
// APA
// 4.3 Code Exercise: API Application


using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Gutierrez_Adrian_CE05
{
    abstract class APIFramework
    {
        // Fields
        protected string _url;
        protected string _jsonString;
        protected dynamic _json;

        public void Connect()
        {
            using (WebClient wc = new WebClient())
            {
                // Getting the string json from the url
                _jsonString = wc.DownloadString(_url);


                // assigning the object to hold the parsed json taken from the json string
                _json = JObject.Parse(_jsonString);

                Console.WriteLine(_json.Title);


            }
        }
    }
}
