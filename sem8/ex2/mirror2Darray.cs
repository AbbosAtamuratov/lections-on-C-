// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

/*----------MAIN--------------*/

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, cols];

FillArray2D(numbers);
PrintArray2D(numbers);

if (rows != cols)
{
    Console.Write("Это невозможно...\nВсего хорошего...");
    return;
}

int[,] turnAround = new int[rows, cols];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        turnAround[i, j] = numbers[j, i];
    }
}

PrintArray2D(turnAround);
// решение без 2го массива
//
// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         int temp = numbers[i, j];
//         numbers[i, j] = numbers[j ,i];
//         numbers[j, i] = temp;
//     }
// }
// PrintArray(numbers);
