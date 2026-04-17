namespace LR4;

public class RailwayStation
{
    private string _name;
    private uint _totalSeats;
    private uint _soldTickets;
    private readonly RailwayTicket _ticket;

    public static RailwayStation Instance { get; } = new RailwayStation();

    private RailwayStation()
    {
        _name = "";
        _totalSeats= 0;
        _soldTickets = 0;
        _ticket = new RailwayTicket(0);
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public uint TotalSeats
    {
        get => _totalSeats;
        set => _totalSeats = value;
    }

    public uint TicketPrice
    {
        get => _ticket.Price;
        set => _ticket.Price = value;
    }

    public uint SoldTickets
    {
        get => _soldTickets;
        set => _soldTickets = value;
    }

    public uint UnsoldTicketsCost()
    {
        return (_totalSeats - _soldTickets) * _ticket.Price;
    }
    
    public void TicketIncreasePrice(uint amount)
    {
        _ticket.IncreasePrice(amount);
    }

    public void TicketDecreasePrice(uint amount)
    {
        _ticket.DecreasePrice(amount);
    }

    public uint TicketGetPrice()
    {
        return _ticket.Price;
    }
}