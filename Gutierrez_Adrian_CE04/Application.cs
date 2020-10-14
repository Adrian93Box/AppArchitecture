// Adrian Gutierrez
// Oct 14, 2020
// APA
// 3.3 Code Exercise: Interfaces

using System;
using System.Collections.Generic;

namespace Gutierrez_Adrian_CE04
{
    public class Application
    {
        // - A List object which will contain all the animals you create.
        private List<Animal> _animals = new List<Animal>();

        // Instantiating Animal objects
        Gorilla kerchak = new Gorilla();
        Elephant dumbo = new Elephant();
        Monkey abu = new Monkey();
        Cat lucifer = new Cat();
        Lion simba = new Lion();
        Horse spirit = new Horse();

        // Constructor
        public Application()
        {
            // Welcoming the user and adding all animals into the list above '_animals'
            // This also displays the application header by use of the welcome message
            Welcome();
            // Creating the Main Menu using all Animal types from the list '_animals'
            Menu mainMenu = CreateMainMenu();
            // Displaying the Main Menu
            mainMenu.DisplayMenu();
            // Adding the exit option to the end of the Menu
            Console.WriteLine("\n[0] Exit Zoo");
            // Prompting user for menu selection
            int selection = Validate.Range("Please enter your selection by number:", 0, _animals.Count);
            

        }


        // - A method which welcomes the user and adds instances of each animal into the List object.
        public void Welcome()
        {
            // Welcome message
            UI.Header("Welcome to Zookeeper!");

            // Adding objects to the _animals list
            _animals = new List<Animal>() { kerchak, dumbo, abu, lucifer, simba, spirit };

        }

        // This method gets the List of animals and uses their data to create the Main Menu
        // Then it returns the Main Menu as a Menu object
        public Menu CreateMainMenu()
        {
            // Creating an array of strings to create a Main Menu holding all animal types
            string[] animalSArray = new string[_animals.Count];
            string animalType;
            int counter = 0;
            // Adding animal types into array
            foreach (Animal animal in _animals)
            {
                animalType = animal.Species;
                animalSArray[counter] = animalType;
                counter++;
            }

            // Instatniating the Main Menu
            Menu mainMenu = new Menu(animalSArray);

            return mainMenu;
        }



    }
}
