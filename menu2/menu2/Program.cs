namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle bottom-left");
                Console.WriteLine("2. Draw the rectangle");
                Console.WriteLine("3. Draw the square");
                Console.WriteLine("4. Draw the triangle top-left");
                Console.WriteLine("5. Draw the triangle top-right");
                Console.WriteLine("6. Draw the triangle bottom-right");
                Console.WriteLine("7. Draw the isosceles triangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Draw the triangle bottom-left");
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Draw the rectangle");
                        for (int i = 1; i<= 3; i++)
                        {
                            for (int j = 1;j<= 7; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine() ;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Draw the square");
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= 5; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Draw the triangle top-left");
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= 6-i; j++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 5:
                        Console.WriteLine("Draw the triangle top-right");
                        for(int i = 1;  i<= 5;  i++)
                        {
                            for (int j = 1; j<= i; j++)
                            {
                                Console.Write("  ");
                            }
                            for (int k = 1; k<= 6-i; k++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        Console.WriteLine("Draw the triangle bottom-right");
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= 6 - i; j++)
                            {
                                Console.Write("  ");
                            }
                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 7:
                        Console.WriteLine("Draw the isosceles triangle");
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= 5 - i; j++)
                            {
                                Console.Write("  ");
                            }
                            for (int k = 1; k <= i-1; k++)
                            {
                                Console.Write("* ");
                            }
                            for (int q = 1; q <= i; q++)
                            {
                                Console.Write("* ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
