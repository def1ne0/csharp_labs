namespace LR5.Railway;

public class RailwayStation
{
    private readonly List<Ticket> _tariffs = [];
    private readonly List<Customer> _customers = [];

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public void AddTariff(Ticket ticket)
    {
        _tariffs.Add(ticket);
    }

    public void AddTariffs(Ticket[] tickets)
    {
        _tariffs.AddRange(tickets);
    }
    
    // throws exception
    public void Buy(Customer customer, string direction)
    {
        var ticket = _tariffs.Find(ticket => ticket.Direction == direction);

        if (ticket is null) throw new Exception("Ticket not found");
        customer.Buy(ticket);
    }

    // throws exception
    public void Buy(string passportId, string direction)
    {
        var customer = _customers.Find(item => item.PassportId == passportId.Trim());

        if (customer is null) throw new Exception("Client not found");
        Buy(customer, direction);
    }

    // throws exception
    public uint CustomerCart(string passportId)
    {
        var target =  _customers.Find(item => item.PassportId == passportId.Trim());

        if (target is null) throw new Exception("Client not found");

        return target.CartPrice;
    }

    public uint Revenue
    {
        get
        {
            uint total = 0;

            foreach (var customer in _customers)
            {
                total += customer.CartPrice;
            }

            return total;
        }
    }

    public void PrintTariffs()
    {
        foreach (var ticket in _tariffs)
        {
            Console.WriteLine("Рейс {0} стоит {1} ({2})", ticket.Direction, ticket.Price, ticket.Type);
        }
    }

    public void PrintCustomersListOnDirection(string direction)
    {
        foreach (var customer in _customers)
        {
            foreach (var cart in customer.Cart)
            {
                if (cart.Direction == direction.Trim())
                {
                    customer.PrintCart();
                }
            }
        }
    }

    public void PrintCustomers()
    {
        foreach (var customer in _customers)
        {
            customer.PrintCart();
        }
    }
}