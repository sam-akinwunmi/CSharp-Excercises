using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPossibleCardsFromAStandardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 10; i++)
            {
                Console.WriteLine(i + " Spades");
                Console.WriteLine(i + " Clubs");
                Console.WriteLine(i + " Diamonds");
                Console.WriteLine(i + " Hearts");
            }
            string[] pictureCards = {"Ace", "Jack", "Queen", "King"};
            for (int i = 0; i < pictureCards.Length; i++)
            {
                Console.WriteLine(pictureCards[i] + " Spades");
                Console.WriteLine(pictureCards[i] + " Clubs");
                Console.WriteLine(pictureCards[i] + " Diamonds");
                Console.WriteLine(pictureCards[i] + " Hearts");
            }
        }
    }
}
