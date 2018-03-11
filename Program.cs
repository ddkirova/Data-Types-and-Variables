using System;

namespace _09_Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= input; i++)
            {
                int sumOfDigits = 0;
                int currentNumber = i;
                while (currentNumber > 0)
                {
                    sumOfDigits += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                bool isTrue = (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);
                Console.WriteLine($"{i} -> {isTrue}");
            }
        }
    }
}
