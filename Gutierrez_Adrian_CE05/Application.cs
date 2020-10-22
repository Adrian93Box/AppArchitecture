// Adrian Gutierrez
// 10/21/2020
// APA
// 4.3 Code Exercise: API Application


using System;
namespace Gutierrez_Adrian_CE05
{
    public class Application
    {
        public Application()
        {
            API justiceLeagueAPI = new API("http://www.omdbapi.com/?t=Justice+LEague&apikey=b08784be");
            Console.WriteLine(justiceLeagueAPI.GetTitle());



        }
    }
}
