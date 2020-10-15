// Adrian Gutierrez
// Oct 14, 2020
// APA
// 3.3 Code Exercise: Interfaces

using System;
using System.Collections.Generic;

namespace Gutierrez_Adrian_CE04
{
    public interface ITrainable
    {
        // - Behaviors
        // - The key (a string) is the signal the trainer/user will use to ask the animal to perform a behavior.
        // - The value (a string) is the behavior the animal will perform when it sees the signal.
        Dictionary<string, string> Behaviors { get; set; }


        // - Perform
        // - Fetch the behavior from the Behaviors dictionary based on the signal.
        // - Should return a string describing how the animal performed the behavior in response to the signal.
        string Perform(string signal);

        // - Train
        // - Needs a string parameter that holds the signal sent by the user.
        // - Will add the behavior to the Behaviors dictionary using the signal as the key.
        // - Should return a string describing how the animal has been trained and will respond to the specified signal.
        string Train(string signal, string behavior);
    }
}
