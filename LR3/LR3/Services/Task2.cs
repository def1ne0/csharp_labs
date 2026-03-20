namespace LR3.Services;

using Menus;
using InputUtils;

public static class Task2
{
    private static double FunctionOfX(double x)
    {
        return Math.Pow(Math.Sin(x * x - 1), 3) + Math.Log(Math.Abs(x)) + Math.Exp(x);
    }

    private static Tuple<double, string> CalculateX(double z)
    {
        if (z <= 0)
        {
            return new Tuple<double, string>(z * z + 5, "первая, x = z^2 + 5");
        }
            
        return new Tuple<double, string>(1 / Math.Sqrt(z - 1), "вторая, x = 1/sqrt(z-1)");
    }

    private static void DoTask()
    {
        const double eps = 1e-10;
        Console.WriteLine("f(x) = sin^3(x^2 - 1) + ln|x| + e^x");
        var z = InputDouble.GetInputWith("Введите z");

        while (Math.Abs(z - 1) < eps)
        {
            Console.WriteLine("z не может быть 1");
            z = InputDouble.GetInputWith("Введите z");
        }

        var x = CalculateX(z);
        var fX = FunctionOfX(x.Item1);
        
        Console.WriteLine("f({0}) = {1}; Ветка: {2} = {3}", z, fX, x.Item2, x.Item1);
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