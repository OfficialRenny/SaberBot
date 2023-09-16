using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Interfaces.Games.Cards
{
    public interface ICardValue
    { 
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
