namespace LR1 {
    internal static class Program 
    {
        public static void Main() 
        {
            if (int.TryParse(Console.ReadLine(), out var firstValue) &&
                int.TryParse(Console.ReadLine(), out var secondValue) && 
                secondValue != 0) 
            {
                Console.WriteLine($"Остаток { firstValue } от деления на { secondValue } равен { firstValue % secondValue }");
            }
            else 
            {
                Console.WriteLine("Some exception has occured while parsing");
            }
        }
    }
}

