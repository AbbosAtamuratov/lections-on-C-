//  Напишите программу, которая заполнит спирально массив 4 на 4

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]<10)
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
    int starter = 1;
    int steps = 2*array.GetLength(0)-1;
    for (int m = 0; m < steps; m++)
    {
        for (int i = 0; i < array.GetLength(1)-m; i++)
        {
           
        }        
    }
}

Console.Clear();
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];

FillArraySpirally(array);
PrintArray2D(array);