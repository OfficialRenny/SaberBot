using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Models.Games.Cards
{
    public class PlayingCardDeck : Deck<PlayingCard>
    {
        public override void Generate()
        {
            foreach (var suit in CardSuit.PlayingCardSuits)
            {
                foreach (var rank in CardValue.PlayingCardValues)
                {
                    Add(new PlayingCard(suit, rank));
                }
            }
        }
    }
}
