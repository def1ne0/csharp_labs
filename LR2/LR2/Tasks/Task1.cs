using LR2.InputUtils;
using LR2.Menus;

namespace LR2.Tasks;

public static class Task1
{
    private static bool IsInt(string str)
    {
        
        foreach (var ch in str)
        {
            if (ch > '9' || ch < '0')
            {
                return false;
            }
        }

        return true;
    }

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
    
    public static void DoTask()
    {
        while (true)
        {
            var input = InputString.GetInput("Введите трехзначное число").Trim();

            if (input.Length != 3 || !IsInt(input))
            {
                Console.WriteLine("Неверный ввод");  
                continue;
            }
            
            if (input[0] < input[2])
            { 
                Console.WriteLine("Первая цифра меньше последней");
            }
            else if (input[0] > input[2]) 
            { 
                Console.WriteLine("Первая цифра больше последней");
            }
            else
            { 
                Console.WriteLine("Первая цифра равна последней");
            }
            
            return;
        }
    }
}