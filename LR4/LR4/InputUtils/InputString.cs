namespace LR4.InputUtils;

public static class InputString
{
    public static string GetInputWith(string preInput = "")
    {
        Console.WriteLine(preInput);

        return GetInput;
    }
    
    public static string GetInput
    {
        get
        {
            while (true)
            {
                Console.Write("[>>] ");
                var temp = Console.ReadLine();

                if (temp is not null)
                {
                    return temp;
                }
            
                Console.WriteLine("Error during string input");
            }
        }
    }
}