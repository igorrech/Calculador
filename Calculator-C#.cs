using System;

namespace projectSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Custom Console 

            Console.ForegroundColor = ConsoleColor.Blue;

            // User Selection 

            Console.WriteLine(" ---> CALCULATOR <--- ");
            Console.WriteLine();
            Console.WriteLine(" -- Sum = ENTER 1");
            Console.WriteLine(" -- Subtract = ENTER 2");
            Console.WriteLine(" -- Multiply = ENTER 3");
            Console.WriteLine(" -- Divide = ENTER 4");
            Console.WriteLine(" -- SquareRoot = ENTER 5");
            Console.WriteLine(" -- NumberModule = ENTER 6");
            Console.WriteLine(" -- QuadraticEquationPos = ENTER 7");
            Console.WriteLine(" -- QuadraticEquationNeg = ENTER 8");
            Console.WriteLine(" -- Factorial = ENTER 9");

            int userrSelection = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            // switch with operator 

            switch (userrSelection)
            {
                case 1:                  
                    Sum();
                    break;
                case 2:
                    Div();
                    break;
                case 3:
                    Multiply();
                    break;
                case 4:
                    Divide();
                    break;
                case 5:
                    SquareRoot();
                    break;
                case 6:
                    NumberModule();
                    break;
                case 7:
                    QuadraticEquationPos();
                    break;
                case 8:
                    QuadraticEquationNeg();
                    break;
                case 9:
                    Factorial();
                    break;
            }

        }
        static void SquareRoot()
        {
            Console.WriteLine("Enter the number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The Square root of {number} is " + Math.Sqrt(number));
        }
        static void NumberModule()
        {
            Console.WriteLine("Enter the number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The NumberModule is: " + Math.Abs(number));
        }
        static void QuadraticEquationPos()
        {
            double disc, deno, x1, x2, a, b, c;

            Console.WriteLine("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the three number: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine("The roots are Linear: ", x1);
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;
                if (disc > 0)
                {
                    Console.WriteLine("THE ROOTS ARE REAL AND DISTINCT ROOTS");
                    x1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                    x2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                    Console.WriteLine("THE ROOTS ARE... " + x1 + " and " + x2);
                }
                else if (disc == 0)
                {
                    Console.WriteLine("THE ROOTS ARE REPEATED ROOTS");
                    x1 = -b / deno;
                    Console.WriteLine("THE ROOT IS...: " + x1);
                }
                else
                {
                    Console.WriteLine("THE ROOTS ARE IMAGINARY ROOTS\n");
                    x1 = -b / deno;
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    Console.WriteLine("THE ROOT 1: " + x1 + "+i" + x2);
                }
            }
            Console.ReadLine();

        }
        static void QuadraticEquationNeg()
        {
            double disc, deno, x1, x2, a, b, c;

            Console.WriteLine("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the three number: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine("The roots are Linear: ", x1);
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;
                if (disc > 0)
                {
                    Console.WriteLine("THE ROOTS ARE REAL AND DISTINCT ROOTS");
                    x1 = (-b / deno) + (Math.Sqrt(disc) / deno);
                    x2 = (-b / deno) - (Math.Sqrt(disc) / deno);
                    Console.WriteLine("THE ROOTS ARE... " + x1 + " and " + x2);
                }
                else if (disc == 0)
                {
                    Console.WriteLine("THE ROOTS ARE REPEATED ROOTS");
                    x1 = -b / deno;
                    Console.WriteLine("THE ROOT IS...: " + x1);
                }
                else
                {
                    Console.WriteLine("THE ROOTS ARE IMAGINARY ROOTS\n");
                    x1 = -b / deno;
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    Console.WriteLine("THE ROOT 2:" + x1 + "-i" + x2);
                }
            }
            Console.ReadLine();

        }
        static void Factorial()
        {
            Console.WriteLine("Enter the number: ");
            double a = Convert.ToInt32(Console.ReadLine());
            double factorial = 1;

            for (double i = 1; i <= a; i++)
            {
                factorial = factorial * i;                
            }
            Console.WriteLine($"The factorial of {a} is {factorial}");
        }
        static void Sum()
        {
            Console.WriteLine("Enter the first number: ");
            double numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number: ");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            double sum = numero1 + numero2;
            Console.WriteLine($"The result is {sum}");
        }
        static void Div()
        {
            Console.WriteLine("Enter the first number: ");
            double numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number: ");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            double sub = numero1 - numero2;
            Console.WriteLine($"The result is {sub}");
        }
        static void Multiply()
        {
            Console.WriteLine("Enter the first number: ");
            double numero1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter the first number: ");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            double multiply = numero1 * numero2;
            Console.WriteLine($"The result is {multiply}");
        }
        static void Divide()
        {
            Console.WriteLine("Enter the first number: ");
            double numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first number: ");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            double divide = numero1 / numero2;
            Console.WriteLine($"The result is {divide}");
        }
    }
}
