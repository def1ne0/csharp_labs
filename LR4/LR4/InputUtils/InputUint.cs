namespace LR4.InputUtils;

public class InputUint
{
    public static uint GetInputWith(string preInput = "")
    {
        Console.WriteLine(preInput);

        return GetInput;
    }
    
    public static uint GetInput
    {
        get
        {
            while (true)
            {
                Console.Write("[>>] ");
                
                if (uint.TryParse(Console.ReadLine(), out var temp))
                {
                    return temp;
                }
            
                Console.WriteLine("Error during input uint");
            }
        }
    }
}