using System;
using Xunit;
using Lab07Collections.Classes;

namespace Lab07CollectionsTDD
{
    public class UnitTest1
    {
        [Fact]
        public void AddTestOne()
        {
            Card test1 = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Ace };
            Card test2 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Seven };
            Card test3 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Eight };
            Deck<Card> deck = new Deck<Card>();
            deck.Add(test1);
            deck.Add(test2);
            Assert.True(deck.Add(test3));
        }

        [Fact]
        public void AddTestTwo()
        {
            Card test1 = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Ace };
            Card test2 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Seven };
            Card test3 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Eight };
            Deck<Card> deck = new Deck<Card>();
            deck.Add(test1);
            deck.Add(test3);
            Assert.True(deck.Add(test2));
        }

        [Fact]
        public void AddTestThree()
        {
            Card test1 = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Ace };
            Card test2 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Seven };
            Card test3 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Eight };
            Deck<Card> deck = new Deck<Card>();
            deck.Add(test2);
            deck.Add(test3);
            Assert.True(deck.Add(test1));
        }

        [Fact]
        public void RemoveTestOne()
        {
            Card test1 = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Ace };
            Card test2 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Seven };
            Card test3 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Eight };
            Deck<Card> deck = new Deck<Card>();
            deck.Add(test1);
            deck.Add(test2);
            deck.Add(test3);
            Assert.True(deck.Remove(test1));
        }

        [Fact]
        public void RemoveTestTwo()
        {
            Card test1 = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Ace };
            Card test2 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Seven };
            Card test3 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Eight };
            Deck<Card> deck = new Deck<Card>();
            deck.Add(test1);
            deck.Add(test2);
            deck.Add(test3);
            Assert.True(deck.Remove(test2));
        }

        [Fact]
        public void RemoveTestThree()
        {
            Card test1 = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Ace };
            Card test2 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Seven };
            Card test3 = new Card() { SuitsCard = Card.Suits.Spades, FaceCard = Card.Face.Eight };
            Card test4 = new Card() { SuitsCard = Card.Suits.Clubs, FaceCard = Card.Face.Four };
            Deck<Card> deck = new Deck<Card>();
            deck.Add(test1);
            deck.Add(test2);
            deck.Add(test3);
            Assert.False(deck.Remove(test4));
        }
    }
}
