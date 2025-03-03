using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CYFinalExamReview
{
    internal class PlayingCard
    {
        public string Suit;
        public int Value;

        public PlayingCard()
        {
            Suit = "No suit";
            Value = 0;
        }

        public PlayingCard(string suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public bool IsValid()
        {
            string[] validSuits = { "spade", "heart", "club", "diamond" };
            return validSuits.Contains(Suit.ToLower()) && (Value >= 1 && Value <= 13);
        }

        public void Write()
        {
            string filename = "CYPlayingCard.txt";
            using (StreamWriter sw = new StreamWriter(filename, true))
            {
                sw.WriteLine($"{Suit},{Value}");
            }
        }
    }
}
