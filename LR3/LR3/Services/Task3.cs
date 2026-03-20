namespace LR3.Services;

using InputUtils;
using Menus;

public static class Task3
{
    private static DayOfWeek GetCorrectDay
    {
        get
        {
            while (true)
            {
                var s = InputString.GetInputWith("Input date like YYYY.MM.DD");

                if (DateService.GetDay(s, out var res))
                {
                    return res;
                }
                
                Console.WriteLine("Error while parsing date");
            }
        }
    }

    private static int GetCorrectSpan
    {
        get
        {
            while (true)
            {
                var year = InputInt.GetInputWith("Input year");
                var month = InputInt.GetInputWith("Input month");
                var day = InputInt.GetInputWith("Input day");
                
                if (DateService.GetDaysSpan(year, month, day, out var res))
                {
                    return res;
                }
                
                Console.WriteLine("Error while parsing date");
            }
        }
        
    }
    
    private static void DoTask()
    {
        var someDate = GetCorrectDay;
        
        Console.WriteLine("Day of week : {0}", someDate);
        var dateSpan = GetCorrectSpan;
        
        Console.WriteLine("The span between this day and today is {0}", dateSpan);
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