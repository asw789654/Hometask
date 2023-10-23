namespace Homework33
{
    internal class ArrayCheck
    {
        public static void findDuplicates(int[] numbers)
        {
            bool isFullIdentical = true;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        isFullIdentical = false;
                        Console.WriteLine(numbers[j]);
                        break;
                    }
                }
            }
            if (isFullIdentical)
            {
                Console.WriteLine("Значения массива идентичны");
            }

        }
    }
}
