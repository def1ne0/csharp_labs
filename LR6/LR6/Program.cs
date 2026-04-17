namespace LR6;

using ComputerTechLab;

internal static class Program
{
    public static void Main()
    {
        Console.WriteLine("=== Лабораторная работа: Компьютерная техника ===\n");

        Console.WriteLine("--- 1. Создание объектов (цепочка конструкторов) ---");
        var laptop = new Laptop("Apple", "MacBook Pro 16", 2500.0, 90);
        var pc = new DesktopPc("Custom", "WorkStation X", 1800.0, "RTX 4080");
        var server = new Server("Dell", "PowerEdge R750", 4500.0, 2);
        
        Console.WriteLine("\n--- 2. Включение устройств ---");
        laptop.TurnOn();
        pc.TurnOn();
        server.TurnOn();
        
        Console.WriteLine("\n--- 3. Виртуальный метод GetDeviceInfo() ---");
        Console.WriteLine(laptop.DeviceInfo());
        Console.WriteLine(pc.DeviceInfo()); 
        Console.WriteLine(server.DeviceInfo()); 
        
        Console.WriteLine("\n--- 4. Абстрактный метод CalculatePerformanceScore() ---");
        Console.WriteLine($"Laptop:  {laptop.CalculatePerformanceScore():F2} у.е.");
        Console.WriteLine($"DesktopPC: {pc.CalculatePerformanceScore():F2} у.е.");
        Console.WriteLine($"Server:  {server.CalculatePerformanceScore():F2} у.е.");
        
        Console.WriteLine("\n--- 5. Скрытие метода (new) и вызов base.PrintStatus() ---");
        pc.PrintStatus();
        
        Console.WriteLine("\n--- 6. Переименование и динамика ---");
        laptop.Rename("MacBook Pro 16 M3 Max");
        pc.UpgradeGpu("RTX 4090");
        laptop.MoveToLocation("Конференц-зал Б");
        server.DeployService("Docker Container: Web-App");
    }
}
