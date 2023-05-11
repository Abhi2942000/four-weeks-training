using System;
namespace LogicalPrograms
{
    public class Fibonacci
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number to print Fibonacci Series : ");
            int number = int.Parse(Console.ReadLine());
            FibonacciSeries(0, 1, 1, number);
            Console.ReadKey();
        }
        public static void FibonacciSeries(int Number1, int Number2, int counter, int number)
        {
            Console.Write(Number1 + " ");
            if (counter < number)
            {
                FibonacciSeries(Number2, Number1 + Number2, counter + 1, number);
            }
        }
    }
}