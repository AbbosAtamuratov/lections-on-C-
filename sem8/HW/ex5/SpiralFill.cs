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
    int m = 0;
    int starter = 1;
    while (m < array.GetLength(0))
    {
        for (int j = m; j < array.GetLength(1)-m; j++)
        {
            array[m, j] = starter;
            starter++;
        }
        m++;
        for (int i = m; i <= array.GetLength(0)-m; i++)
        {
            array[i, array.GetLength(1) - 1] = starter;
            starter++;
        }

        for (int j = array.GetLength(1) - m - 1; j >= 0; j--)
        {
            array[array.GetLength(0) - m, j] = starter;
            starter++;
        }
    }
}

Console.Clear();
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];

FillArraySpirally(array);
PrintArray2D(array);