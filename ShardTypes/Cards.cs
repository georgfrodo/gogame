// TODO: ADD YOUR CARDS HERE

namespace ShardTypes;

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
            Name = "Trap Card Title",
            Description = "Trap description",
            NumberOfDrinks = 1,
            Type = CardType.Trap,
            ImageName = "card2.png",
        },
        new Card()
        {
            Name = "Effect Card",
            Description = "You now have an effect",
            NumberOfDrinks = 1,
            Type = CardType.Effect,
            Duration = 3,
            ImageName = "card3.png",
        },
        // Add more cards here
    };
}
