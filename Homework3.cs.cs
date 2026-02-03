namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //This is beginning of Q1
        Console.Write("Input an integer: ");
        int N = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (N <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
              if (isPrime)
        {
            Console.WriteLine("N is prime");
        }
        else
        {
            Console.WriteLine("N is non-prime");
        }
        //This is ending of Q1

        //This is beginning of Q2
        Console.Write("Assign an int value to N: ");
        int n2 = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n2; row++)
        {
            for (int col = 1; col <= n2; col++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
        //This is ending of Q2

        //This is beginning of Q3
        Console.Write("Assign an int value for N: ");
        int n3 = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n3; row++)
        {
            for (int col = 1; col <= n3; col++)
            {
                if (col <= row)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        //This is ending of Q3
    }
}