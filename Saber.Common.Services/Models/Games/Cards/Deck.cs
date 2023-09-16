using Saber.Common.Services.Interfaces.Games.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Models.Games.Cards
{
    public abstract class Deck<T> : IDeck<T> where T : ICard
    {
        public List<T> Cards { get; set; }

        public Deck()
        {
            Cards = new List<T>();
        }

        public void Add(T card)
        {
            Cards.Add(card);
        }

        public void Add(IEnumerable<T> cards)
        {
            Cards.AddRange(cards);
        }

        public void Clear()
        {
            Cards.Clear();
        }

        public T Draw(bool faceUp = false)
        {
            var card = Cards.First();
            Cards.Remove(card);
            card.IsFaceUp = faceUp;
            return card;
        }

        public IEnumerable<T> Draw(int count, bool faceUp = false)
        {
            var cards = Cards.Take(count);
            Cards.RemoveRange(0, count);
            foreach (var card in cards)
            {
                card.IsFaceUp = faceUp;
            }
            return cards;
        }

        public abstract void Generate();

        public void Shuffle()
        {
            Cards = Cards.Shuffle().ToList();
        }
    }
}
