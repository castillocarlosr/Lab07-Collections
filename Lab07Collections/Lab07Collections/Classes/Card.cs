using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07Collections.Classes
{
    public class Card
    {
        public enum Suits { Hearts, Diamonds, Clubs, Spades }
        public enum Face { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }

        public Suits SuitsCard { get; set; }
        public Face FaceCard { get; set; }
        /*
        public Card(Suits suits, Face face)
        {
            SuitsCard = suits;
            FaceCard = face;
        }
        */
    }
}
