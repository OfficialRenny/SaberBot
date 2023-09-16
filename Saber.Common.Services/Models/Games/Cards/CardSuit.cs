using Saber.Common.Services.Interfaces.Games.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Models.Games.Cards
{
    public class CardSuit : ICardSuit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Symbol { get; set; }

        public CardSuit(string name, string color, string symbol)
        {
            Name = name;
            Color = color;
            Symbol = symbol;
        }

        public static List<CardSuit> PlayingCardSuits => new()
        {
            new CardSuit("Clubs", "Black", "♣"),
            new CardSuit("Diamonds", "Red", "♦"),
            new CardSuit("Hearts", "Red", "♥"),
            new CardSuit("Spades", "Black", "♠")
        };
    }
}
