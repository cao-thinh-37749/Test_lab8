using System;

namespace ProjectCode
{
    public class ArrayHelper
    {
        public static int FindMax(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array is empty or null");

            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max) max = num;
            }
            return max;
        }

        public static int FindMin(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("Array is empty or null");

            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min) min = num;
            }
            return min;
        }
    }
}
