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
            var choice = InputInt.GetInput;

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
        const double eps = 10e-10;
        
        var x = InputDouble.GetInputWith("Введите координату х");
        var y = InputDouble.GetInputWith("Введите координату y");

        if (x > 50 || y > 25 || x < -50 || y < -25)
        {
            Console.WriteLine("Точка не принадлежит графической области");
        } 
        else if (Math.Abs(x - 50) < eps || Math.Abs(y - 25) < eps || Math.Abs(x + 50) < eps || Math.Abs(y + 25) < eps)
        {
            Console.WriteLine("Точка находится на границе графической области, принадлежит");
        }
        else
        {
            Console.WriteLine("Точка находится внутри графической области");
        }
    }
}