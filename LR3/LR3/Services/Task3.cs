namespace LR3.Services;

using InputUtils;
using Menus;

public static class Task3
{
    private static DayOfWeek GetCorrectDay(string s)
    {
        while (true)
        {
            if (DateService.GetDay(s, out var res))
            {
                return res;
            } 
        }
    }

    private static int GetCorrectSpan(int year, int month, int day)
    {
        while (true)
        {
            if (DateService.GetDaysSpan(year, month, day, out var res))
            {
                return res;
            }
        }
    }
    
    private static void DoTask()
    {
        Console.WriteLine("Input date like YYYY.MM.DD");
        
        var someDate = InputString.GetInput;
        
        Console.WriteLine("Day of week of {0}: {1}", someDate, GetCorrectDay(someDate));
        
        var year = InputInt.GetInputWith("Input year");
        var month = InputInt.GetInputWith("Input month");
        var day = InputInt.GetInputWith("Input day");
        var dateSpan = GetCorrectSpan(year, month, day);
        
        Console.WriteLine("The span between {0}.{1}.{2} and today is {3}", year, month, day, dateSpan);
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