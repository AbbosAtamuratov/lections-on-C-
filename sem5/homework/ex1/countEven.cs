// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        array1[i] = new Random().Next(100, 1000);
}

int CountEven(int[] array1)
{
    int counter = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] % 2 == 0)
            counter++;
    }
    return counter;
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
    Console.WriteLine();
}

int size = ReadInt("Введите размер массива: ");
int[] array = new int[size];
int result=0;

FillArrayRandomNumbers(array);
PrintArray(array);
result = CountEven(array);
Console.Write($"В вашем массиве {result} чётных элементов.");