namespace LR3;

public class Task1
{
    public static int Min(int a, int b)
    {
        if (a <= b)
        {
            return a;
        }

        return b;
    }

    public static int Max(int a, int b)
    {
        if (a >= b)
        {
            return a;
        }

        return b;
    }

    public static double f_x(double x)
    {
        return x - Math.Sin(x);
    }

    public static uint f_n(uint n)
    {
        return n * n;
    }

    public static double f_n_x(uint n, double x)
    {
        return Math.Pow(x, n) / n;
    }

    public static uint Even(uint x)
    {
        if (x % 2 != 0)
        {
            return 0;
        }
        
        return x / 2;
    }
    
    
}