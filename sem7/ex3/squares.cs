//  Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, 
// и замените эти элементы на их квадраты.

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
            array[i, j] = new Random().Next(0, 10);
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
int cols = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, cols];

FillArray2D(numbers);
PrintArray2D(numbers);

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i % 2 == 1 && j % 2 == 1)
        {
            array[i, j] *= array[i, j];
        }

    }

}
PrintArray2D(array);