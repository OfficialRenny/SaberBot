using Saber.Common.Services.Interfaces.Games.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Models.Games.Cards
{
    public class PlayingCard : ICard
    {
        public ICardSuit Suit { get; set; }
        public ICardValue Value { get; set; }
        public bool IsFaceUp { get; set; }
        public bool IsAce => Value.Name == "Ace";
        public bool IsFaceCard => Value.Name == "Jack" || Value.Name == "Queen" || Value.Name == "King";
        public int PointValue => IsAce ? 11 : IsFaceCard ? 10 : Value.Value;
        public string Name => $"{Value.Name} of {Suit.Name}";
        public string ShortName => $"{Value.Name.ToString().First()} {Suit.Name.ToString().First()}";
        public string Emoji => $"{Suit.Name.ToString().First().ToString().ToLower()}{Value.Name.ToString().First().ToString().ToLower()}";

        public PlayingCard(ICardSuit suit, ICardValue value, bool isFaceUp = false)
        {
            Suit = suit;
            Value = value;
            IsFaceUp = isFaceUp;
        }
    }
}
