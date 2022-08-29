int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);

int minIndexI = 0;
int minIndexJ = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if(numbers[minIndexI, minIndexJ] > numbers[i, j])
        {
            minIndexI = i;
            minIndexJ = j;
        }
    }
}

int[,] newNumbers = new int[numbers.GetLength(0) - 1, numbers.GetLength(1) - 1];
int shiftI = 0;
int shiftJ = 0;

for (int i = 0; i < newNumbers.GetLength(0); i++)
{
    for (int j = 0; j < newNumbers.GetLength(1); j++)
    {
        if(i >= minIndexI)
        {
            shiftI = 1;
        }
        else
        {
            shiftI = 0;
        }

        if(j >= minIndexJ)
        {
            shiftJ = 1;
        }
        else
        {
            shiftJ = 0;
        }

        newNumbers[i, j] = numbers[i + shiftI, j + shiftJ];
    }
}
PrintArray(newNumbers);


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

