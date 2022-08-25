// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 9);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*--------------MAIN---------------*/
int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt ("Введите количество столбцов: ");
int[,] numbers = new int[rows, cols];
FillArray2D(numbers);
PrintArray2D(numbers);