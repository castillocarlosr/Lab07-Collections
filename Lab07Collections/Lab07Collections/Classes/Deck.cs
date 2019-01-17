using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07Collections.Classes
{
    public class Deck<T> : IEnumerable
    {
        public T[] deck = new T[10];
        int count = 0;

        /// <summary>
        /// used to add a single card to the deck
        /// </summary>
        /// <param name="card"></param>
        public void Add(T card)
        {
            if(count == deck.Length)
            {
                //Vinicio taught the class this.  Thanks Vinicio.
                Array.Resize(ref deck, deck.Length * 2);
            }
            deck[count++] = card;
        }

        /// <summary>
        /// Used to remove a single card from the deck
        /// </summary>
        /// <param name="card"></param>
        public void Remove(T card)
        {
            for (int i = 0; i < count; i++)
            {
                if(deck[i] != null && deck[i].Equals(card))
                {
                    //deck.SetValue(null, i);
                    //break;
                    deck[i] = deck[--count];
                }
            }
        }
        /*
        public int Count()
        {
            return deck;
        }
        */
        /// <summary>
        /// Allows for loops to be used on deck Collections
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return deck[i];
            }
        }

        /// <summary>
        /// Needed to calling Generic.  C#1.  Just in case.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
