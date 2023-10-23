using Homework31;

int[] numbers;
int lenth, result = 0;
bool isRightArray = true;

while (isRightArray)
{
    Console.Write("Введите размерность массива: ");
    lenth = NumberCheck.AskForNumber("число");


    if (lenth > 2)
    {
        Console.WriteLine("Заполните массив");
        numbers = new int[lenth];
        isRightArray = false;
        for (int number, i = 0; i < lenth; i++)
        {
            Console.Write($"Число {i + 1}:");
            number = NumberCheck.AskForNumber("число");
            numbers[i] = number;
            result += numbers[i];
        }
        Console.WriteLine($"Сумма значений массива: {result}");
    }
    else
    {
        Console.WriteLine("Неверная размерность массива\n");
    }
}