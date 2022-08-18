int size = 12;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sumNegative = 0;
int sumPositive = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        sumPositive += numbers[i];
    else
        sumNegative += numbers[i];
}

Console.WriteLine($"Сумма положительных элементов равна {sumPositive}\n" +
                   $"Сумма отрицательных равна {sumNegative}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

