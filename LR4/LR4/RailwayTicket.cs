namespace LR4;

public class RailwayTicket(uint price)
{
    private uint _price = price;
    
    public RailwayTicket() : this(0) {}

    public uint GetPrice()
    {
        return _price;
    }

    public void SetPrice(uint newPrice)
    {
        _price = newPrice;
    }

    public void IncreasePrice(uint amount)
    {
        _price += amount;
    }

    public void DecreasePrice(uint amount)
    {
        if ((int) _price - (int) amount < 0) throw new Exception("Negative price during decreasing");
        _price -= amount;
    }
}