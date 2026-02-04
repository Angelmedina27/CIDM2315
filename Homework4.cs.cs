namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1_method()
        Console.Write("Input an integer: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Input an integer: ");
        int num2 = int.Parse(Console.ReadLine());

        int largest = Q1_method(num1, num2);
        Console.WriteLine("The largest integer is: " + largest);

        // Call Q2_method()
        Console.Write("\nEnter N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter shape (left or right): ");
        string shape = Console.ReadLine();

        Q2_method(N, shape);
    }
        // Q1_method
        static int Q1_method(int num1, int num2)
    {
        if (num1 > num2)
            return num1;
        else
            return num2;
    }
        // Q2_method
        static void Q2_method(int N, string shape)
    {
        Console.WriteLine("N is: " + N + "; shape is " + shape);

        if (shape == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        else if (shape == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string(' ', N - i) + new string('*', i));
            }
        }
    }
}