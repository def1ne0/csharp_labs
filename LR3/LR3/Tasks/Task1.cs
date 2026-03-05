using LR3.InputUtils;

namespace LR3.Tasks;

using Menus;

public static class Task1
{
    private static double FunctionOfX(double x)
    {
        return x - Math.Sin(x);
    }

    private static Tuple<double, double> MinFunctionValue(double a, double b)
    {
        var fA = FunctionOfX(a);
        var fB= FunctionOfX(b);

        return fA <= fB ?  new Tuple<double, double>(a, fA) : new Tuple<double, double>(b, fB);
    }

    private static void DoTask()
    {
        Console.WriteLine("f(x) = x - sin(x)");
        var x = InputDouble.GetInputWith("Введите x");
        var a = InputDouble.GetInputWith("Введите а");
        var b = InputDouble.GetInputWith("Введите b");
        
        var res = FunctionOfX(x);
        var smallest = MinFunctionValue(a, b);
        
        Console.WriteLine("f({0}) = {1} \n Min of (f({2}), f({3})) is f({4}) = {5}", 
            x, res, a, b, smallest.Item1, smallest.Item2);
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