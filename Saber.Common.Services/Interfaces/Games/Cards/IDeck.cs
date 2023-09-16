using Saber.Common.Services.Models.Games.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Interfaces.Games.Cards
{
    public interface IDeck<T> where T : ICard
    {
        public List<T> Cards { get; set; }

        public void Generate();
        public void Shuffle();
        public T Draw(bool faceUp);
        public IEnumerable<T> Draw(int count, bool faceUp);
        public void Add(T card);
        public void Add(IEnumerable<T> cards);
        public void Clear();
    }
}
