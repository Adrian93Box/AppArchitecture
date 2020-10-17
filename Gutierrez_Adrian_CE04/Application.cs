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
        private bool _run = true;
        // Temp variable holding the users selected animal
        private Animal _chosenAnimal;

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
            // Creating submenu
            Menu subMenu = CreateSubMenu();
            

            // MAIN WHILE LOOP that runs the Program
            while (_run)
            {
                // Displaying the Main Menu
                mainMenu.DisplayMenu();
                // Adding the exit option to the end of the Menu
                Console.WriteLine("\n[0] Exit Zoo");
                // Prompting user for menu selection
                int selection = Validate.Range("Please enter your selection by number:", 0, _animals.Count);

                // checking to see if the user would like to exit the program
                if (selection == 0)
                {
                    _run = false;
                    UI.Alert("Goodbye!!");
                }
                else
                {
                    // Temp variable to save the animal that was chosen
                    _chosenAnimal = _animals[selection - 1];
                    // Displaying what you have chosen
                    UI.Alert($"You have chosen the {_chosenAnimal.Species}");

                    // Will run submenu until the user chooses another animal
                    while (_run)
                    {
                        // Displaying sub menu
                        subMenu.DisplayMenu();
                        // Saving the count for the submenu's options
                        int subMenuCount = subMenu.MenuOptions.Length;

                        // getting users selection
                        selection = Validate.Range("Please enter your selection by number:", 1, subMenuCount);

                        // checking to see if the user would like to choose another animal
                        if (selection == subMenuCount)
                        {
                            _run = false;
                        } else
                        {
                            // Calling the submenu controller and passing in the users selection as well as the current animal
                            SubMenuController(selection);
                        }
                    }

                    // Resetting _run to true so it works as expected with the main loop
                    _run = true;
                    


                }
            }


            

        }


        // - A method which welcomes the user and adds instances of each animal into the List object.
        public void Welcome()
        {
            // Welcome message
            Console.WriteLine("Welcome to Zookeeper!");
            UI.Separator();

            // Adding objects to the _animals list
            _animals = new List<Animal>() { kerchak, dumbo, abu, lucifer, simba, spirit };

        }



        // This method creates the menu of options for animals
        public Menu CreateSubMenu()
        {
            string[] menuOptions = { "Train the animal in a new behavior.", "Feed animal a treat.",
                "Signal to the animal to perform a behavior", "Listen to the animal make a noise.", "Select a different animal." };

            Menu menu = new Menu(menuOptions);

            return menu;
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


                // If the Animal is trainable then this loop would add it
                if (animal is ITrainable)
                {
                    animalSArray[counter] = animalType + " (Trainable)";
                } else
                {
                    animalSArray[counter] = animalType;
                }
                
                counter++;
            }

            // Instatniating the Main Menu
            Menu mainMenu = new Menu(animalSArray);

            return mainMenu;
        }





        // The controller for the submenu
        // Holds a switch and case inside to nav through the menu actions
        public void SubMenuController(int selection)
        {
            

            // Switching through the menu options according to the user's selection
            switch (selection)
            {
                case 1:
                    if (_chosenAnimal is ITrainable)
                    {
                        // Prompting user to create a new behavior according to a signal
                        string behavior = Validate.String($"What new behavior are you training the {_chosenAnimal.Species} to do?");
                        string signal = Validate.String($"What signal will you use when asking the {_chosenAnimal.Species} to do" +
                            $" this new behavior?");
                        // saving input
                        UI.Alert(((ITrainable)_chosenAnimal).Train(signal, behavior));
                    } else
                    {
                        UI.Alert($"The {_chosenAnimal.Species} is not Trainable!");
                    }
                    break;
                case 2:
                    _chosenAnimal.Eat();
                    break;
                case 3:
                    if (_chosenAnimal is ITrainable)
                    {
                        if (((ITrainable)_chosenAnimal).Behaviors.Count == 0)
                        {
                            UI.Alert($"The {_chosenAnimal.Species} has not yet been trained!");
                        }
                        else
                        {
                            Console.WriteLine("\n-------------------------------");
                            Console.Write("Signals:\n");
                            // Searches all available keys and displays them like a menu
                            foreach (string key in ((ITrainable)_chosenAnimal).Behaviors.Keys)
                            {
                                Console.WriteLine(key);
                            }
                            // getting signal through proper validation
                            string signal = Validate.Key("Please enter your signal:", ((ITrainable)_chosenAnimal).Behaviors);
                            // Displaying the performance
                            UI.Alert(((ITrainable)_chosenAnimal).Perform(signal));
                        }
                    }
                    else
                    {
                        UI.Alert($"The {_chosenAnimal.Species} is not Trainable!");
                    }
                    break;
                case 4:
                    UI.Alert(_chosenAnimal.MakeNoise());
                    break;
                default:
                    UI.Alert("An error has occured in the Submenu Controller");
                    break;
            }
        }

    }
}
