// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array1, int min, int max)
{
    for (int i = 0; i < array1.Length; i++)
        array1[i] = new Random().Next(min, max);
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
    Console.WriteLine();
}

int CalcNotEvenElements (int[] array1)
{
    int sum = 0;
    for (int i = 1; i < array1.Length; i+=2)
        sum += array1[i];
    return sum;
}

int minimum = 0;
int maximum = 10;
int size = ReadInt("Введите размер массива: ");
int[] array = new int [size];
FillArrayRandomNumbers(array, minimum, maximum);
PrintArray(array);
int res = CalcNotEvenElements(array);
Console.Write($"Сумма нечётных элементов равна {res}");