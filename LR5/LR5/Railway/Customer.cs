namespace LR5.Railway;

public class Customer(string fullname, string passportId)
{
    private readonly List<Ticket> _cart = [];
    private readonly string _fullname = fullname;
    private string _passportId = passportId;

    public string Fullname => _fullname;

    public string PassportId
    {
        get => _passportId;
        set => _passportId = value;
    }

    public void Buy(Ticket ticket)
    {
        _cart.Add(ticket);
    }

    public uint CartPrice
    {
        get
        {
            uint total = 0;
            
            foreach (var item in _cart)
            {
                total += item.Price;
            }

            return total;
        }
    }

    public void PrintCart()
    {
        Console.WriteLine("***** Корзина клиента {0} *****", _fullname);

        foreach (var ticket in _cart) 
        {
            Console.WriteLine("Билет {0} класса на рейс {1}, цена: {2} ", ticket.Type, ticket.Direction, ticket.Price);
        }
        
        Console.WriteLine("Суммарная стоимость: {0}", CartPrice);
    }

    public List<Ticket> Cart => _cart;
}