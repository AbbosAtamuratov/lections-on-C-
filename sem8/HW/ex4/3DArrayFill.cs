// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


void PrintArray3D(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        Console.WriteLine($"\nОсь {k}:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]} - ({i},{j},{k})     ");
            }
            Console.WriteLine();
        }
    }
}

void Fill3DArray(int[,,] array)
{
    int modifier = 10;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = modifier;
                modifier++;
            }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.Clear();
int rows1 = ReadInt("Введите количество строк: ");
int columns1 = ReadInt("Введите количество столбцов: ");
int axis1 = ReadInt("Введите количество осей: ");
int[,,] array = new int[rows1, columns1, axis1];


Fill3DArray(array);
PrintArray3D(array);