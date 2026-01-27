namespace LR2.InputUtils;

public static class InputInt
{
    public static int GetInput(string preInput = "")
    {
        Console.WriteLine(preInput);
        
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out var temp))
            {
                return temp;
            }
            
            Console.WriteLine("Ошибка");
        }
    }
}