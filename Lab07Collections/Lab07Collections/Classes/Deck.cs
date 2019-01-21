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
        public bool Add(T card)
        {
            if(count == deck.Length)
            {
                //Vinicio taught the class this.  Thanks Vinicio.
                Array.Resize(ref deck, deck.Length * 2);
            }
            deck[count++] = card;
            return true;
        }

        /// <summary>
        /// To remove the card
        /// </summary>
        /// <param name="card"></param>
        public bool Remove(T card)
        {
            for (int i = 0; i < count; i++)
            {
                if (deck[i] != null && deck[i].Equals(card))
                {
                    //deck.SetValue(null, i);
                    //break;
                    deck[i] = deck[--count];
                    return true;
                }
            }
            return false;
        }
        
        //This was covered in class but ran out of time to implement changes to my code.
        /*
        public void Remove(T item)
        {
            T[] temp = new T[(count - 1)];
            int tempcount = 0;

            foreach (T card in deck)
            {
                if(!card.Equals(item))
                {
                    temp[tempcount] = card;
                    tempcount++;
                }
            }
            deck = temp;
            count--;
        }
        

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
