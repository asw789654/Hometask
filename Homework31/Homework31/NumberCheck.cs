namespace Homework31
{
    internal class NumberCheck
    {
        public static int AskForNumber(string numberName)
        {
            int number;
            while (true)
            {
                var input = Console.ReadLine();
                if (IsInt(input))
                {
                    number = int.Parse(input);
                    break;
                }
                else
                {
                    Console.Write($"Неверный формат числа.{Environment.NewLine}Введите {numberName} снова: ");
                }
            }
            return number;
        }
        private static bool IsInt(string input)
        {
            bool isNumber = false;
            if (!string.IsNullOrWhiteSpace(input))
            {
                if (int.TryParse(input, out int number))
                {
                    isNumber = true;
                }
            }
            return isNumber;
        }
    }
}

