// Adrian Gutierrez
// 10/01/2020
// APA
// 1.2 Code Exercise

using System;
namespace War
{
    public class Card
    {
        // Create a private field for the card's suit (This should be an integer)
        // It will eventually store a number from 0 to 3
        private int _suit;

        // Create a public property for the value of the card. This will hold a
        // number from 1 to 13
        public int CardValue { get; set; }

        // Create a constructor that accepts suit and value in parameters and
        // sets the value and suit classmember variables accordingly
        public Card(int suit, int cardValue)
        {
            _suit = suit;
            CardValue = cardValue;
        }

        //Create a method to display the value of the card. This should return a string.
            // Assume a suit of 0 is Spades, 1 is Hearts, 2 is Diammonds & 3 is Clubs
            // If the card value is 12 and suit is 0 the card
            // then this method should return "The Queen of Spades"
        public string DisplayCard()
        {
            // Variables
            string suit;
            string value;

            // switch and case for suit value
            switch (_suit)
            {
                case 0:
                    suit = "Spades";
                    break;
                case 1:
                    suit = "Hearts";
                    break;
                case 2:
                    suit = "Clubs";
                    break;
                case 3:
                    suit = "Diamonds";
                    break;
                default:
                    suit = "Error";
                    break;
            }

            // switch and case for card value
            switch (CardValue)
            {
                case 11:
                    value = "Jack";
                    break;
                case 12:
                    value = "Queen";
                    break;
                case 13:
                    value = "King";
                    break;
                case 1:
                    value = "Ace";
                    break;
                default:
                    value = CardValue.ToString();
                    break;
            }

            return $"The {value} of {suit}";
        }

    }
}
