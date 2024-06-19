using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Console Calculator\n");
                Console.WriteLine("Enter first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operator: + - * /");
                string op = Console.ReadLine();

                double result = 0;
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        continue;
                }

                Console.WriteLine($"Result: {result}");
                Console.WriteLine("Press any key to perform another calculation or Ctrl+C to exit.");
                Console.ReadKey();
            }
        }
    }
}
