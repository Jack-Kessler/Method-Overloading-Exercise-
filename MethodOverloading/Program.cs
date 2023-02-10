namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        static decimal Add(decimal a, decimal b)
        {
            decimal sum = a + b;
            return sum;
        }

        static string Add(int a, int b, bool c)
        {
            if (c == true)
            {
                int sum = a + b;
                if (sum == 0 || sum > 1)
                {
                    return $"{sum} dollars";
                }
                else
                {
                    return $"{sum} dollar";
                }
            }
            else
            {
                return "Error: This should never happen.";
            }
        }
    }
}
