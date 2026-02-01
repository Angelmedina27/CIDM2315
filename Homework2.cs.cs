namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        //This is beginning of Q1
        Console.Write("Please input a letter grade: ");
        string grade = Console.ReadLine().ToUpper();

         if (grade == "A")
        {
            Console.WriteLine("GPA point: 4");
        }
        else if (grade == "B")
        {
            Console.WriteLine("GPA point: 3");
        }
        else if (grade == "C")
        {
            Console.WriteLine("GPA point: 2");
        }
        else if (grade == "D")
        {
            Console.WriteLine("GPA point: 1");
        }
        else if (grade == "F")
        {
            Console.WriteLine("GPA point: 0");
        }
        else
        {
            Console.WriteLine("Wrong Letter Grade!");
        }
        //This is ending of Q1


        //This is beginning of Q2
        Console.Write("Please input the first num: ");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the second num: ");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please input the third num: ");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest;

        if (num1 <= num2 && num1 <= num3)
        {
            smallest = num1;
        }
        else if (num2 <= num1 && num2 <= num3)
        {
            smallest = num2;
        }
        else
        {
            smallest = num3;
        }

        Console.WriteLine("The smallest value is: " + smallest);
        //This is ending of Q2
    }
}