using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Interfaces.Games.Cards
{
    public interface ICardSuit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Symbol { get; set; }
    }
}
