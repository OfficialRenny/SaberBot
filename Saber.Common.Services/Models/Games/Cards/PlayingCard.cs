using Saber.Common.Services.Interfaces.Games.Cards;

namespace Saber.Common.Services.Models.Games.Cards;

public class PlayingCard : ICard
{
    public PlayingCard(ICardSuit suit, ICardValue value, bool isFaceUp = false)
    {
        Suit = suit;
        Value = value;
        IsFaceUp = isFaceUp;
    }

    public bool IsAce => Value.Name == "Ace";
    public bool IsFaceCard => Value.Name == "Jack" || Value.Name == "Queen" || Value.Name == "King";
    public int PointValue => IsAce ? 11 : IsFaceCard ? 10 : Value.Value;
    public string Name => $"{Value.Name} of {Suit.Name}";
    public string ShortName => $"{Value.Name.First()} {Suit.Name.First()}";
    public string Emoji => $"{Suit.Name.First().ToString().ToLower()}{Value.Name.First().ToString().ToLower()}";
    public ICardSuit Suit { get; set; }
    public ICardValue Value { get; set; }
    public bool IsFaceUp { get; set; }
}