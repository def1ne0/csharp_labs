namespace LR5.InputUtils;

public static class InputInt
{
    public static int GetInputWith(string preInput = "")
    {
        Console.WriteLine(preInput);

        return GetInput;
    }
    
    public static int GetInput
    {
        get
        {
            while (true)
            {
                Console.Write("[>>] ");
                
                if (int.TryParse(Console.ReadLine(), out var temp))
                {
                    return temp;
                }
            
                Console.WriteLine("Error during int input");
            }
        }
    }
}