using Saber.Common.Services.Interfaces.Games.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Models.Games.Cards
{
    public class CardValue : ICardValue
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public CardValue(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public static List<CardValue> PlayingCardValues => new()
        {
            new CardValue("Ace", 1),
            new CardValue("Two", 2),
            new CardValue("Three", 3),
            new CardValue("Four", 4),
            new CardValue("Five", 5),
            new CardValue("Six", 6),
            new CardValue("Seven", 7),
            new CardValue("Eight", 8),
            new CardValue("Nine", 9),
            new CardValue("Ten", 10),
            new CardValue("Jack", 11),
            new CardValue("Queen", 12),
            new CardValue("King", 13)
        };
    }
}
