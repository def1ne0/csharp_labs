namespace LR3.Services;

public static class DateService
{
    public static bool GetDay(string date, out DayOfWeek res)
    {
        res = DayOfWeek.Monday;
        var dateSplitted = date.Split(".");

        if (dateSplitted.Length != 3)
        {
            return false;
        }

        if (!int.TryParse(dateSplitted[0], out var year) ||
            !int.TryParse(dateSplitted[1], out var month) ||
            !int.TryParse(dateSplitted[2], out var day))
        {
            return false;
        }

        try
        {
            var correctDate = new DateTime(year, month, day);
            res = correctDate.DayOfWeek;
            return true;
        }
        catch 
        {
            return false;
        }
    }

    public static bool GetDaysSpan(int year, int month, int day, out int res)
    {
        res = 0;

        try
        {
            var correctDate = new DateTime(year, month, day);
            res = Math.Abs(correctDate.Subtract(DateTime.Now).Days);
            
            return true;
        }
        catch
        {
            return false;
        }
    }
}