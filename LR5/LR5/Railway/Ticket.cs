namespace LR5.Railway;

public enum TicketType
{
    Premium,
    Business,
    Default,
}

public class Ticket(uint price, TicketType type, string direction)
{
    private uint _price = price;
    private TicketType _type = type;
    private string _direction = direction;

    public uint Price
    {
        get => _price; 
        set => _price = value;
    }

    public TicketType Type
    {
        get => _type; 
        set => _type = value;
    }

    public string Direction
    {
        get => _direction; 
        set => _direction = value.Trim();
    }
}