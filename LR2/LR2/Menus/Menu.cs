namespace LR2.Menus;

public static class Menu
{
    public static void ShowMainMenu() 
    {
        Console.WriteLine("Введи пункт меню: ");
        Console.WriteLine(" -> 0. Выход");
        Console.WriteLine(" -> 1. Задание 1");
        Console.WriteLine(" -> 2. Задание 2");
        Console.WriteLine("---------------------");
    }

    public static void ShowTasksMenu()
    {
        Console.WriteLine("Выбери: ");
        Console.WriteLine(" -> 0. Закончить");
        Console.WriteLine(" -> 1. Продолжить");
        Console.WriteLine("---------------------");
    }
}