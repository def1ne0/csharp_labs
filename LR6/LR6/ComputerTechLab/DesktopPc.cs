namespace LR6.ComputerTechLab;

public class DesktopPc : ComputerDevice
{
    private string _gpu;
    
    public DesktopPc(string brand, string model, double price, string gpu)
        : base(brand, model, price)
    {
        _gpu = gpu;
        Console.WriteLine($"[DESKTOP] Инициализация ПК. Видеокарта: {gpu}\n");
    }

    public string Gpu
    {
        get => _gpu;
        set => _gpu = value;
    }
    
    
    public override double CalculatePerformanceScore()
    {
        return (Price / 1000) * 1.2;
    }
    
    public new void PrintStatus()
    {
        base.PrintStatus(); 
        Console.WriteLine($"[DESKTOP] ПК {_model} работает на GPU: {Gpu}. Питание стабильное.");
    }
    
    public void UpgradeGpu(string newGpu)
    {
        Console.WriteLine($"[DESKTOP] GPU обновлена. Было: {Gpu} -> Стало: {newGpu}");
        Gpu = newGpu;
    }
}