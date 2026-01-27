namespace LR2.Tasks;
using Menus; 
using InputUtils;
    
public static class Task2
{
    public static void ExecuteTask()
    {
        DoTask();
        
        var exit = false;

        while (!exit)
        {
            Menu.ShowTasksMenu();
            var choice = Menu.Choice;

            switch (choice)
            {
                case 0:
                    exit = true;
                    break;
                case 1:
                    DoTask();
                    break;
            }
        }
    }

    private static void DoTask()
    {
        var x = InputInt.GetInput("Введите координату х");
        var y = InputInt.GetInput("Введите координату y");

        if (x > 50 || y > 25 || x < -50 || y < -25)
        {
            Console.WriteLine("Точка не принадлежит графической области");
        } else if (x == 50 || y == 25 || x == -50 || y == -25)
        {
            Console.WriteLine("Точка находится на границе графической области");
        }
        else
        {
            Console.WriteLine("Точка находится внутри графической области");
        }
    }
}