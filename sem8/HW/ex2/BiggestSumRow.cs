// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int FindMaxIndex (int[] array)
{
    int maxIndex=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>array[maxIndex])
            maxIndex = i;    
    }
    return maxIndex;
}

int[] RowSums (int[,] array)
{
    int[] sums = new int [array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sums[i] += array[i,j];  
        }
    }
    return sums;
}
/*---------------------MAIN------------------------------*/

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];

FillArray2D(array);
PrintArray2D(array);
Console.WriteLine ($"{FindMaxIndex(RowSums(array))+1}я строка имеет наибольшую сумму.");