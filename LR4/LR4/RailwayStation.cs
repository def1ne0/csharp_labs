namespace LR4;

public class RailwayStation
{
    private string _name;
    private uint _totalSeats;
    private uint _soldTickets;
    private readonly RailwayTicket _ticket;

    private RailwayStation()
    {
        _name = "";
        _totalSeats= 0;
        _soldTickets = 0;
        _ticket = new RailwayTicket(0);
    }

    public static RailwayStation Instance
    {
        get
        {
            return field ??= new RailwayStation(); 
        } 
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    
    public void SetTotalSeats(uint newTotalSeats)
    {
        _totalSeats = newTotalSeats;
    }

    public void SetTicketPrice(uint price)
    {
        _ticket.SetPrice(price);
    }

    public void SetSoldTickets(uint count)
    {
        _soldTickets = count;
    }

    public uint UnsoldTicketsCost()
    {
        return (_totalSeats - _soldTickets) * _ticket.GetPrice();
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
        return _ticket.GetPrice();
    }
}