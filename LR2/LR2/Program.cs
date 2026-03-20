namespace  LR2;

using InputUtils;
using Tasks;
using Menus;

internal static class Program
{ 
    public static void Main() {
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
                default:
                    Console.WriteLine("Неверный пункт меню");
                    break;
            }
        }
    }
}