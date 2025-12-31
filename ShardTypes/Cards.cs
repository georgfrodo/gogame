// TODO: COPY THIS FILE AS Cards.cs AND ADD YOUR CARDS

namespace ShardTypes;

//Available card types: CardType.Action, CardType.Trap, CardType.Effect
public static class Cards
{
    public static List<Card> AvailableCards = new()
    {
        new Card()
        {
            Name = "Name of Card 1",
            Description = "Everyone drinks",
            NumberOfDrinks = 1,
            Type = CardType.Action,
            ImageName = "card1.png",
        },
        new Card()
        {
            Name = "Second Card Title",
            Description = "You drink",
            NumberOfDrinks = 1,
            Type = CardType.Action,
            ImageName = "card2.png",
        },
        // Add more cards here
    };
}
