namespace ShardTypes;

public class Card
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageName { get; set; } = string.Empty;
    public CardType Type { get; set; }
    public int NumberOfDrinks { get; set; }
    
    public int Duration { get; set; }
}

public enum CardType
{
    Action,
    Trap,
    Effect
}

public class PlayCardData
{
    public string? PlayerName { get; set; }
    public string CardName { get; set; } = string.Empty;
}