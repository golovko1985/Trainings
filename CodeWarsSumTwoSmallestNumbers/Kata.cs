using System;

namespace CodeWarsSumTwoSmallestNumbers
{
    public static class Kata
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            if (numbers.Length < 4) return -1;

            int firstMin = numbers[0], secondMin = numbers[1];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < firstMin)
                    firstMin = numbers[i];
                if (numbers[i] < secondMin && numbers[i] != firstMin)
                    secondMin = numbers[i];
            }
            return firstMin + secondMin;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Console.WriteLine("Answer is: " + Kata.sumTwoSmallestNumbers(numbers));
            Console.WriteLine("expected value: " + 13);
        }
    }
}
