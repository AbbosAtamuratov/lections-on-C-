// See https://aka.ms/new-console-template for more information

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(double[] array1, int min, int max)
{
    for (int i = 0; i < array1.Length; i++)
        array1[i] = new Random().Next(min, max) + 0.1 * new Random().Next(0, 10);
}

void PrintArray(double[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + "    ");
    Console.WriteLine();
}

double MinMax(double[] array1)
{
    double result = 0;
    double min = array1[0];
    double max = array1[0];
    for (int i = 0; i < array1.Length; i++)
        if (array1[i] > max) max = array1[i];
    for (int j = 0; j < array1.Length; j++)
        if (array1[j] < min) min = array1[j];
    result = Math.Round(max - min, 2);
    return result;
}

int minimum = 1;
int maximum = 5;
int size = ReadInt("Введите размер массива: ");
double[] array = new double[size];
FillArrayRandomNumbers(array, minimum, maximum);
PrintArray(array);
Console.Write($"Разница между минимальным и максимальным значениями массива: {MinMax(array)}");