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
        List<Animal> animals = new List<Animal>();

        // Constructor
        public Application()
        {

        }


        // - A method which welcomes the user and adds instances of each animal into the List object.
        public void Welcome()
        {
            // Welcome message
            Console.WriteLine("Welcome to Zookeeper!");

            // Instantiating Animal objects
            Gorilla kerchak = new Gorilla();
            Elephant dumbo = new Elephant();
            Monkey abu = new Monkey();
            Cat lucifer = new Cat();
            Lion simba = new Lion();
            Horse spirit = new Horse();
        }



    }
}
