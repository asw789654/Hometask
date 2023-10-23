using Homework33;

int[] numbers;
int lenth;
bool isRightArray = true;

while (isRightArray)
{
    Console.Write("Введите размерность массива: ");
    lenth = NumberCheck.AskForNumber("число");


    if (lenth > 1)
    {
        Console.WriteLine("Заполните массив");
        numbers = new int[lenth];
        isRightArray = false;
        for (int number, i = 0; i < lenth; i++)
        {
            Console.Write($"Число {i + 1}:");
            number = NumberCheck.AskForNumber("число");
            numbers[i] = number;
        }
        Console.WriteLine("Повторяющиеся значения: ");
        ArrayCheck.findDuplicates(numbers);
    }

}

