namespace LR3;

using InputUtils;
using Menus;
using Tasks;
using Services;

internal static class Program
{
    public static void Main()
    {
        var exit = false;
        
        while (!exit)
        {
            Menu.ShowMainMenu();
            var choice = InputInt.GetInput;

            switch (choice)
            {
                case 0:
                    exit = true;
                    break;
                case 1:
                    Task1.ExecuteTask();
                    break;
                case 2:
                    Task2.ExecuteTask();
                    break;
                case 3:
                    Task3.ExecuteTask();
                    break;
                default:
                    Console.WriteLine("Неверный пункт меню");
                    break;
            }
        }
    }
}