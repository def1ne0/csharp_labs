namespace LR4.InputUtils;

public static class InputDouble
{
    public static double GetInputWith(string preInput = "")
    {
        Console.WriteLine(preInput);

        return GetInput;
    }
    
    public static double GetInput
    {
        get
        {
            while (true)
            {
                Console.Write("[>>] ");
                
                if (double.TryParse(Console.ReadLine(), out var temp))
                {
                    return temp;
                }
            
                Console.WriteLine("Error during input double");
            }
        }
    }
}