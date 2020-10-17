// Adrian Gutierrez
// Oct 14, 2020
// APA
// 3.3 Code Exercise: Interfaces

using System;
namespace Gutierrez_Adrian_CE04
{
    abstract class Animal
    {
        // PROPERTIES/FIELDS

        // - A property named Species. This will hold the animal’s name (i.e. dolphin)
        public string Species { get; set; }

        // - A field named _foodConsumed to keep track of how much food the animal has consumed.
        private int _foodConsumed = 0;

        // - A field named _treat used to store the name of the food this animal likes to eat as a treat.
        // - (like fish for dolphins, rats for snakes). This will need to be set to protected access since
        // - it will be used in subclasses to set the value unique to each animal.
        protected string _treat;



        // CONSTRUCTOR 
        public Animal()
        {
        }



        // ALL METHODS

        // - Eat
        // - Tracks how much food has been consumed.
        // - If the animal eats over 4 times it should trigger the Poop() method and reset the _foodConsumed field.
        // - It should return a string describing how the animal ate the food that looks like this: "The dolphin ate a herring”
        public string Eat()
        {
            // Adding one to food eatin
            _foodConsumed++;
            //Displaying the animal ate
            UI.Alert($"The {Species} ate a {_treat}");

            // Conditional to determine if the animal was full enough to poop.
            if (_foodConsumed == 4)
            {
                _foodConsumed = 0;
                Poop();
            }

            return $"The {Species} ate a {_treat}";
        }


        // - MakeNoise
        // - This will be overridden later and should be virtual.
        // - This should return a string. This will be overriding later but should return a default string.
        // - (If your code is correctly created you should not see the default in your working application.)
        public virtual string MakeNoise()
        {
            return "Error - Make noise method was not overriden!";
        }


        // - Poop
        // - This should not return anything.
        // - This should write out to the console that the animal has pooped. For ex: "The dolphin pooped!”
        public void Poop()
        {
            UI.Alert($"The {Species} pooped!");
        }

    }
}
