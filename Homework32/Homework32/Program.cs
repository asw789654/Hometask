using Homework32;

int[] numbers;
int lenth, maximum, minimum;
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
        minimum = numbers[0];
        maximum = numbers[0];
        for (int i = 0; i < lenth; i++)
        {
            if (numbers[i] < minimum)
            {
                minimum = numbers[i];
            }
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
        }
        Console.WriteLine($"Максимальное значение в массиве: {maximum}");
        Console.WriteLine($"Минимальное значение в массиве: {minimum}");
    }
    else
    {
        Console.WriteLine("Неверная размерность массива\n");
    }

}



