using System;

namespace AEB_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int sum = AddInt(a, b);
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
        }
        static List<int> AddPrimeNumbersInNumericList(List<int> numbers)
        {
            List<int> primeNumbers = new List<int>();
            foreach (int number in numbers)
            {
            if (IsPrime(number))
            {
                primeNumbers.Add(number);
            }
            }
            return primeNumbers;
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
            if (number % i == 0) return false;
            }
            return true;
        }


        static int AddInt(int x, int y)
        {
            return x + y;
        }
    }
}