using System;

namespace CodeWarsSumTwoSmallestNumbers
{
    public static class Kata
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            if (numbers.Length < 4) return -1;

            int firstIndex = 0, firstMin = int.MaxValue, secondMin = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < firstMin)
                {
                    firstMin = numbers[i];
                    firstIndex = i;
                }
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i != firstIndex && numbers[i] < secondMin)
                {
                    secondMin = numbers[i];
                }
            }
            return firstMin + secondMin;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 0,2,3 };
            Console.WriteLine("Answer is: " + Kata.sumTwoSmallestNumbers(numbers));
            Console.WriteLine("expected value: " + 1);
        }
    }
}
