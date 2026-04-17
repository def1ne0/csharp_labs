namespace LR6.ComputerTechLab;

public class Laptop : ComputerDevice
{
    private int _batteryCapacity;
    
    public Laptop(string brand, string model, double price, int battery)
        : base(brand, model, price)
    {
        BatteryCapacity = battery;
        Console.WriteLine($"[LAPTOP] Инициализация ноутбука. Ёмкость: {battery} Вт·ч\n");
    }

    public int BatteryCapacity
    {
        get => _batteryCapacity;
        set => _batteryCapacity = value > 0 ? value : 0;
    }
    
    public override string DeviceInfo()
    {
        var baseInfo = base.DeviceInfo();
        return $"{baseInfo} | Батарея: {BatteryCapacity} Вт·ч";
    }
    
    public override double CalculatePerformanceScore()
    {
        return (Price / 1000) * 0.8 + (double) BatteryCapacity / 10;
    }
    
    public void MoveToLocation(string location)
    {
        Console.WriteLine($"[LAPTOP] Ноутбук {_model} перемещён в локацию: {location}");
    }
}