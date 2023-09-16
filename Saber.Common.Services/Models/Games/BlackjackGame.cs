using Discord;
using Saber.Common.Services.Models.Games.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Models.Games
{
    public class BlackjackGame
    {
        public IUser InitiatedBy { get; set; }

        public Deck<PlayingCard> Deck { get; set; }
        public List<PlayingCard> DealerHand { get; set; } = new();
        public List<PlayingCard> PlayerHand { get; set; } = new();

        public event EventHandler? PlayerWins;
        public event EventHandler? PlayerLoses;

        public int InitialBet { get; set; }
        public int BetPool { get; set; }

        public BlackjackGame(IUser user, int bet)
        {
            InitiatedBy = user;
            InitialBet = bet;
            BetPool = bet;
            Deck = new PlayingCardDeck();
            Deck.Generate();
            Deck.Shuffle();
        }

        public void Deal()
        {
            DealerHand.Add(Deck.Draw());
            PlayerHand.Add(Deck.Draw());
            DealerHand.Add(Deck.Draw());
            PlayerHand.Add(Deck.Draw());
        }

        public void Hit()
        {
            PlayerHand.Add(Deck.Draw());
        }

        public void Stand()
        {
            while (DealerHand.Sum(c => c.PointValue) < 17)
            {
                DealerHand.Add(Deck.Draw());
            }
        }

        public void Double()
        {
            BetPool += InitialBet;
            PlayerHand.Add(Deck.Draw());
        }

        public void Split()
        {
            var card = PlayerHand[0];
            PlayerHand.RemoveAt(0);
            PlayerHand.Add(Deck.Draw());
            PlayerHand.Add(card);
        }
        
        public Moves[] GetAvailableMoves()
        {
            var moves = new List<Moves>();
            if (PlayerHand.Count == 2)
            {
                moves.Add(Moves.Double);
                if (PlayerHand[0].Value == PlayerHand[1].Value)
                {
                    moves.Add(Moves.Split);
                }
            }
            moves.Add(Moves.Hit);
            moves.Add(Moves.Stand);
            return moves.ToArray();
        }

        public enum Moves
        {
            Hit,
            Stand,
            Double,
            Split
        }
    }
}
