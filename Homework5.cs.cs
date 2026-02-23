namespace Homework5;
    class Program
    {
        static void Main(string[] args)
        {
            // Call Q1_method()
            int largestQ1 = Q1_method();
            Console.WriteLine("The largest number is: " + largestQ1);
            Console.WriteLine();

            // Call Q2_method()
            int largestQ2 = Q2_method();
            Console.WriteLine("The largest number is: " + largestQ2);
            Console.WriteLine();

             // Call Q3_method()
            createAccount();
        }

        //This is beginning of Q1
        static int Q1_method()
        {
            Console.Write("Insert first number (a): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Insert second number (b): ");
            int b = int.Parse(Console.ReadLine());

            int max;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            return max;
        }
        //This is ending of Q1

        //This is beginning of Q2
        static int Q2_method()
        {
            Console.Write("Insert first number (a): ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Insert second number (b): ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Insert third number (c): ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Insert fourth number (d): ");
            int d = int.Parse(Console.ReadLine());

            int max1, max2;

            if (a > b)
                max1 = a;
            else
                max1 = b;

            if (c > d)
                max2 = c;
            else
                max2 = d;

            int max;
            if (max1 > max2)
                max = max1;
            else
                max = max2;

            return max;
        }
        //This is ending of Q2

        //This is beginning of Q3
        static bool checkAge(int birth_year)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birth_year;

            if (age >= 18)
                return true;
            else
                return false;
        }

        static void createAccount()
        {
            Console.Write("Enter Your Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Your Password: ");
            string password1 = Console.ReadLine();

            Console.Write("Enter Your Password Again: ");
            string password2 = Console.ReadLine();

            Console.Write("Enter Your Birthyear: ");
            int birthYear = int.Parse(Console.ReadLine());

            if (checkAge(birthYear))
            {
                if (password1 == password2)
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account.");
            }
            //This is ending of Q3
        }
    }