// Adrian Gutierrez
// 10/01/2020
// APA
// 1.2 Code Exercise

using System;
using System.Collections.Generic;

namespace War
{
    public class WarApp
    {
        //create a private list that holds your Players.
        private static List<Player> _players = new List<Player>();

        public WarApp()
        {
            // Create a variable to store a deck and get the deck from the
            // DeckUtility class's CreateDeck method
            List<Card> deck = new List<Card>();
            deck = DeckUtility.CreateDeck();

            // Welcome the user
            // Ask the user for the name of player 1 and player 2. Be sure to validate.
            Console.WriteLine("Welcome!");

            string playerOneName = Validate.IsString("Please enter the name for Player One:");
            string playerTwoName = Validate.IsString("Please enter the name for Player Two:");

            // Create two player objects using the info from the user and store
            // them in the players list you created earlier.
            Player playerOne = new Player(playerOneName);
            Player playerTwo = new Player(playerTwoName);

            _players.Add(playerOne);
            _players.Add(playerTwo);

            // Shuffle Deck
            deck = DeckUtility.ShuffleDeck(deck);
           
            // Give each player half of the deck using the DivideDeck method
            Dictionary<string, List<Card>> deckHalves = DeckUtility.DivideDeck(deck);
            playerOne.deckHalf = deckHalves["first_half"];
            playerTwo.deckHalf = deckHalves["second_half"];

            Play(_players);
        }

        // Play the game
        // I could have made _players 'pivate static' but i decided to pass it instead. I show
        // the other way in the Card class incase you wanted to test that knowledge ...
        public void Play(List<Player> players)
        {
            Console.Clear();
            // Announce the two players by name
            Console.WriteLine($"Welcome, {players[0].Name} and {players[1].Name}!");
            Console.WriteLine("-----------------------\n");
            Console.WriteLine("In this game each player will recieve two halves of a deck.\n" +
                "Each round you will draw your top card and see who has the highest number...\n" +
                "by the end of the game, the player with the highest score wins!\n");
            // Ask the user if they would like to see a round
            // Loop as long as the users have cards in their hands and the user
            // answers "yes" to this question
            while (players[0].deckHalf.Count > 0 && Validate.YesOrNo("Would you like to see a round? [Y] or [N]:"))
            {
                Round(players);
            }

            // When this loop is over you should call the EndGame() method.
            EndGame(players);
        }
        public void Round(List<Player> players)
        {
            // The top Card of each player's deck half
            int topCard = players[0].deckHalf.Count - 1;

            // Draw a card from each player's hand.
            Card p1Card = players[0].deckHalf[topCard];
            Card p2Card = players[1].deckHalf[topCard];

            // Be sure to remove it entirely.
            players[0].deckHalf.RemoveAt(topCard);
            players[1].deckHalf.RemoveAt(topCard);

            // Evaluate who won the round using the cards,
            Console.Clear();
            Console.WriteLine($"{players[0].Name} has {p1Card.DisplayCard()}");
            Console.WriteLine($"{players[1].Name} has {p2Card.DisplayCard()}");
            

            // adjust the score, and ...
            if (p1Card.CardValue > p2Card.CardValue)
            {
                players[0].Score = players[0].Score + 1;
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Player: {players[0].Name} won this round!\n");
            } else
            {
                players[1].Score = players[1].Score + 1;
                Console.WriteLine("-----------------------");
                Console.WriteLine($"Player: {players[1].Name} won this round!\n");
            }

            // ... display it using the DisplayScore method
            DisplayScore(players);

        }
        public void DisplayScore(List<Player> players)
        {
            // Display each player's name and score and how many cards are left in
            // each player's hand
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Player: {players[0].Name} - Score: {players[0].Score} Cards Left: {players[0].deckHalf.Count}");
            Console.WriteLine($"Player: {players[1].Name} - Score: {players[1].Score} Cards Left: {players[1].deckHalf.Count}");
        }
        public void EndGame(List<Player> players)
        {
            Console.Clear();
            // Announce the end of the game
            Console.WriteLine("You have reached the end of the game!");
            // User the player's score to determine who has won the game
            // Announce the winner or if the game was a tie.
            if (players[0].Score > players[1].Score)
            {
                Console.WriteLine($"Player: {players[0].Name} won with a High Score of: {players[0].Score}");
            } else if ((players[1].Score > players[0].Score))
            {
                Console.WriteLine($"Player: {players[1].Name} won with a High Score of: {players[1].Score}");
            } else
            {
                Console.WriteLine("The was no winner!");
            }
        }
    }
}
