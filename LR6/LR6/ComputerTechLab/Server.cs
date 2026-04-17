namespace LR6.ComputerTechLab;

public sealed class Server : ComputerDevice
{
    private int _packetsPerSecond;

    public int PacketsPerSecond => _packetsPerSecond;

    public Server(string brand, string model, double price, int packetsPerSecond)
        : base(brand, model, price)
    {
        _packetsPerSecond = packetsPerSecond;
        Console.WriteLine($"[SERVER] Инициализация сервера. Мощность: {packetsPerSecond} пакетов в секунду\n");
    }
    
    public override double CalculatePerformanceScore()
    {
        return (Price / 500) + (_packetsPerSecond * 10);
    }
    
    public void DeployService(string serviceName)
    {
        Console.WriteLine($"[SERVER] Сервер {Model} развёртывает службу: {serviceName}");
    }
}