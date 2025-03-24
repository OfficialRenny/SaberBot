namespace Saber.Common.Services.Interfaces.Games.Cards;

public interface ICard
{
    public ICardSuit Suit { get; set; }
    public ICardValue Value { get; set; }
    public bool IsFaceUp { get; set; }
}