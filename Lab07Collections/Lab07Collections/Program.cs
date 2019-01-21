using System;
using System.Collections.Generic;
using Lab07Collections.Classes;

namespace Lab07Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Carlos Casino of Cards and Decks!");
            Console.WriteLine("\n");

            Deal();
        }

        public static void Deal()
        {
            Card cardAce = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Ace };
            Card cardTwo = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Two };
            Card cardThree = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Three };
            Card cardFour = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Four };
            Card cardFive = new Card() { SuitsCard = Card.Suits.Diamonds, FaceCard = Card.Face.Five };
            Card cardSix = new Card() { SuitsCard = Card.Suits.Diamonds, FaceCard = Card.Face.Six };
            Card cardSeven = new Card() { SuitsCard = Card.Suits.Diamonds, FaceCard = Card.Face.Seven };
            Card cardEight = new Card() { SuitsCard = Card.Suits.Diamonds, FaceCard = Card.Face.Eight };
            Card cardNine = new Card() { SuitsCard = Card.Suits.Hearts, FaceCard = Card.Face.Nine };
            Card cardTen = new Card() { SuitsCard = Card.Suits.Hearts, FaceCard = Card.Face.Ten };
            Card cardJack = new Card() { SuitsCard = Card.Suits.Hearts, FaceCard = Card.Face.Jack };
            Card cardQueen = new Card() { SuitsCard = Card.Suits.Hearts, FaceCard = Card.Face.Queen };
            Card cardKing = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.King };

            Deck<Card> deck = new Deck<Card>() { cardAce, cardTwo, cardThree, cardFour, cardFive, cardSix, cardSeven, cardEight, cardNine, cardTen, cardJack, cardQueen, cardKing };

            Console.WriteLine("Current cards in the deck by the dealer:");
            foreach (Card card in deck)
            {
                Console.WriteLine($"Card Value: {card.FaceCard},  Card Face: {card.SuitsCard}");
            }
            Console.WriteLine("Player 2 Deck Empty:");
            Console.WriteLine("");

            //Adding cards Player 2
            Card cardSeven2 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Seven };
            Card cardEight2 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Eight };
            Card cardNine2 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Nine };
            deck.Add(cardSeven2);
            deck.Add(cardEight2);
            deck.Add(cardNine2);

            Console.WriteLine("Adding cards to the deck.  7,8,9 of spades shoudl be added.");
            foreach (Card card in deck)
            {
                Console.WriteLine($"Card Value: {card.FaceCard},  Card Face: {card.SuitsCard}");
            }
            Console.WriteLine("");

            //Removing cards from the deck
            deck.Remove(cardAce);
            deck.Remove(cardKing);

            Console.WriteLine("Removing cards from the deck.  Ace, King should be removed.");
            foreach (Card card in deck)
            {
                Console.WriteLine($"Card Value: {card.FaceCard},  Card Face: {card.SuitsCard}");
            }
            Console.WriteLine("");

            Console.ReadLine();

        }

    }
}