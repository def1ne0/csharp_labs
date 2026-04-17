namespace LR6.ComputerTechLab;

public enum DeviceStatus
{
    On,
    Off,
}

public abstract class ComputerDevice
{ 
    protected string _brand;
    protected string _model;
    protected double _price;
    protected DeviceStatus _status;

    public ComputerDevice(string brand, string model, double price)
    {
        _brand = brand;
        _model = model;
        _price = price;
        _status = DeviceStatus.Off;
        Console.WriteLine($"[БАЗА] Вызван конструктор ComputerDevice для {brand} {model}");
    }

    public string Brand
    {
        get => _brand;
        protected set => _brand = value;
    }

    public string Model
    {
        get => _model;
        set => _model = value;
    }

    public double Price
    {
        get => _price;
        protected set => _price = value > 0 ? value : 0;
    }

    public DeviceStatus Status => _status;

    public abstract double CalculatePerformanceScore();

    public virtual string DeviceInfo()
    {
        return $"{_brand} {_model} | Цена: {_price:C} | Питание: {(_status == DeviceStatus.On  ? "Вкл" : "Выкл")}";
    }

    public void TurnOn()
    {
        _status = DeviceStatus.On;
        Console.WriteLine(">> Устройство успешно включено.");
    }
    
    public void Rename(string newModelName)
    {
        _model = newModelName;
        Console.WriteLine($">> Модель переименована в: {_model}");
    }
    
    public void PrintStatus()
    {
        Console.WriteLine($"[БАЗА] Текущий статус питания: {(_status == DeviceStatus.On ? "Активен" : "Отключен")}");
    }
}


