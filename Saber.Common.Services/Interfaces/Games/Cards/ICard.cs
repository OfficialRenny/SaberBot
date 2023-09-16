using Saber.Common.Services.Models.Games.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Interfaces.Games.Cards
{
    public interface ICard
    {
        public ICardSuit Suit { get; set; }
        public ICardValue Value { get; set; }
        public bool IsFaceUp { get; set; }
    }
}
