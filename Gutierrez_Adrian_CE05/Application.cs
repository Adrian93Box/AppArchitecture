// Adrian Gutierrez
// 10/21/2020
// APA
// 4.3 Code Exercise: API Application


// This class holds all application operations

using System;
namespace Gutierrez_Adrian_CE05
{
    public class Application
    {
        // Fields
        private string[] _mainmenuItems = { "Justice League", "Avengers", "Ironman", "Captain America", "Batman vs Superman",
            "Deadpool", "Venom", "Hulk", "Antman", "The Dark Knight" };
        private string _justiceLeagueURL = "http://www.omdbapi.com/?t=Justice+LEague&apikey=b08784be";
        private string _avengersURL = "http://www.omdbapi.com/?t=Avengers&apikey=b08784be";
        private string _ironmanURL = "http://www.omdbapi.com/?t=Iron+man&apikey=b08784be";
        private string _captainAmericaURL = "http://www.omdbapi.com/?t=captain+america&apikey=b08784be";
        private string _batmanVsSupermanURL = "http://www.omdbapi.com/?t=Batman+vs+Superman&apikey=b08784be";
        private string _deadpoolURL = "http://omdbapi.com/?t=Deadpool&apikey=b08784be";
        private string _venomURL = "http://omdbapi.com/?t=Venom&apikey=b08784be";
        private string _hulkURL = "http://www.omdbapi.com/?t=hulk&apikey=b08784be";
        private string _antmanURL = "http://www.omdbapi.com/?t=ant+man&apikey=b08784be";
        private string _theDarkKnightURL = "http://www.omdbapi.com/?t=The+dark+knight&apikey=b08784be";


        // Constructor
        public Application()
        {
            // Instantiatin all available objects
            API justiceLeagueAPI = new API(_justiceLeagueURL);
            API avengersAPI = new API(_avengersURL);
            API ironmanAPI = new API(_ironmanURL);
            API captainAmericaAPI = new API(_captainAmericaURL);
            API batmanVsSupermanAPI = new API(_batmanVsSupermanURL);
            API deadpoolAPI = new API(_deadpoolURL);
            API venomAPI = new API(_venomURL);
            API hulkAPI = new API(_hulkURL);
            API antmanAPI = new API(_antmanURL);
            API theDarkKnightAPI = new API(_theDarkKnightURL);

            // Saving all API's into an array
            API[] apiArray = {justiceLeagueAPI, avengersAPI, ironmanAPI, captainAmericaAPI, batmanVsSupermanAPI,
            deadpoolAPI, venomAPI, hulkAPI, antmanAPI, theDarkKnightAPI};

            // Instantiating the mainMenu
            Menu mainMenu = new Menu(_mainmenuItems);

            // looping until user exits
            while (true)
            {
                // Displaying Application layout
                UI.Header("Movie Library");
                mainMenu.DisplayMenu();
                Console.WriteLine("\n[0] Exit");

                // Prompts for and gets/validates the user's selection
                int userSelection = Validate.Range("Please select a movie by number:", 0, mainMenu.MenuOptions.Length);

                // conditional to continue or exit the program
                if(userSelection == 0)
                {
                    Console.WriteLine("\nGoodbye!");
                    Environment.Exit(0);
                }
                else
                {
                    // Displays the data of the chosen movie
                    apiArray[userSelection - 1].DisplayData();
                }
            }
            
            
        }
    }
}
