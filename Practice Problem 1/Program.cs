using System;

namespace practice_problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number");
            string input1 = Console.ReadLine();
            double number1 = Convert.ToDouble(input1);

            Console.Write("Enter second number");
            string input2 = Console.ReadLine();
            double number2 = Convert.ToDouble(input2);

            double sum = number1 + number2;

            Console.WriteLine("Sum is {0} ",sum);

            Console.ReadLine();
        }
    }
}
