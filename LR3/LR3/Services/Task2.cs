namespace LR3.Services;

using Menus;
using InputUtils;

public static class Task2
{
    private static double FunctionOfX(double x)
    {
        return Math.Pow(Math.Sin(x * x - 1), 3) + Math.Log(Math.Abs(x)) + Math.Exp(x);
    }

    private static void DoTask()
    {
        Console.WriteLine("f(x) = sin^3(x^2 - 1) + ln");
        var x = InputDouble.GetInputWith("Введите х != 0");

        while (x == 0)
        {
            x = InputDouble.GetInputWith("Введите х != 0");
        }
        
        Console.WriteLine("f({0}) = {1}", x, FunctionOfX(x));
    }
    
    public static void ExecuteTask()
    {
        DoTask();
        
        while (true)
        {
            Menu.ShowTasksMenu();

            var choice = InputInt.GetInput;

            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    DoTask();
                    break;
            }
        }
    }
}