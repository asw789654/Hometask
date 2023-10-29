namespace Homework33
{
    internal class ArrayCheck
    {
        public static void FindDuplicates(int[] numbers)
        {
            int[] duplicates = new int[numbers.Length];
            bool isFullIdentical = true;
            for (int i = 0, duplicatedIterator = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1, duplicateCount = 0, duplicatedNumber = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        duplicatedNumber = numbers[i];
                        isFullIdentical = false;
                        duplicateCount++;
                    }
                    if (duplicateCount > 0 && j == numbers.Length - 1)
                    {
                        bool duplicated = false;
                        for (int k = 0; k < duplicates.Length; k++)
                        {
                            if (duplicates[k] == numbers[i])
                            {
                                duplicated = true;
                            }
                        }
                        if (!duplicated)
                        {
                            duplicates[duplicatedIterator] = duplicatedNumber;
                            Console.WriteLine($"Число {duplicatedNumber} имеет {duplicateCount + 1} повторений");
                            duplicatedIterator++;
                        }

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
