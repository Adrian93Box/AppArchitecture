// Adrian Gutierrez
// Oct 14, 2020
// APA
// 3.3 Code Exercise: Interfaces

using System;
using System.Collections.Generic;

// - You will need to implement at least 6 animal classes all should inherit from the Animal base class.
// - Please don't use the animals from the example. Have fun and pick something different and unique.

namespace Gutierrez_Adrian_CE04
{
    class Monkey : Animal, ITrainable
    {
        // Variables
        // List holding behaviors
        public Dictionary<string, string> Behaviors { get; set; }

        // Constructor
        // - The constructors will need to initialize the Species and Trainable properties as well as the _treat field.
        public Monkey()
        {
            Species = "Monkey";
            _treat = "Banana";
            Behaviors = new Dictionary<string, string>();
        }

        // - Perform
        // - Fetch the behavior from the Behaviors dictionary based on the signal.
        // - Should return a string describing how the animal performed the behavior in response to the signal.
        public string Perform(string signal)
        {
            // Returning the behavior associated with the given key 'signal'
            // <string signal> must be validated before the method is called.
            return $"After you {signal}, the {Species} performs {Behaviors[signal]}";
        }

        // - Train
        // - Needs a string parameter that holds the signal sent by the user.
        // - Will add the behavior to the Behaviors dictionary using the signal as the key.
        // - Should return a string describing how the animal has been trained and will respond to the specified signal.
        public string Train(string signal, string behavior)
        {
            Behaviors.Add(signal, behavior);

            return $"The {Species} learned to {behavior} when you make the {signal} signal.";
        }

        // Make Noise
        // This method is overriding the associated method in the Animal Class
        public override string MakeNoise()
        {
            return "oo oo ahh ahh (thumbling though trees)";
        }
    }
}
