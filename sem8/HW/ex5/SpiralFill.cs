//  Напишите программу, которая заполнит спирально массив 4 на 4

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
                Console.Write($"0{array[i, j]} ");
            else
                Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArraySpirally(int[,] array)
{
    int number = 1;
    int cursor = 0;
    int shift = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] = number;
        number++;
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1) - 1] = number;
        number++;
    }
    for (int j = array.GetLength(1) - 1 - 1; j >= 0; j--)
    {
        array[array.GetLength(0) - 1, j] = number;
        number++;
    }
    for (int i = array.GetLength(0) - 1 - 1; i > 0; i--)
    {
        array[i, 0] = number;
        number++;
    }
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        array[1, j] = number;
        number++;
    }
    for (int i = 0 + 1 + 1; i < array.GetLength(0) - 1; i++)
    {
        array[i, array.GetLength(1) - 1 - 1] = number;
        number++;
    }
    for (int j = array.GetLength(1) - 1 - 1 - 1; j > 0; j--)
    {
        array[array.GetLength(0) - 1-1, j] = number;
        number++;
    }
}

Console.Clear();
int[,] array = new int[4, 4];

FillArraySpirally(array);
PrintArray2D(array);