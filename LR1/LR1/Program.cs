namespace LR1 {
    internal static class Program 
    {
        public static void Main() 
        {
            if (double.TryParse(Console.ReadLine(), out var firstValue) &&
                double.TryParse(Console.ReadLine(), out var secondValue) && 
                secondValue != 0) 
            {
                Console.WriteLine("Частное {0} от деления на {1} равно {2}", firstValue, secondValue, firstValue / secondValue);
            }
            else 
            {
                Console.WriteLine("Произошла ошибка");
            }
        }
    }
}

