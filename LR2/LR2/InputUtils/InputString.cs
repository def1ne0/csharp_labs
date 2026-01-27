namespace LR2.InputUtils;

public static class InputString
{
    public static string GetInput(string preInput = "")
    {
        Console.WriteLine(preInput);
        
        while (true)
        {
            var temp = Console.ReadLine();

            if (temp is not null)
            {
                return temp;
            }
            
            Console.WriteLine("Ошибка");
        }
    }
}