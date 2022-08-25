// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

string NoExcessSpaces(string input)
{
    input = input.Trim(' ');
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ' ' && input[i + 1] == ' ')
        {
            input = input.Remove(i, 1);
            i--;
        }
    return input;
}

/*--------------MAIN---------------*/

int rows = ReadInt("Введите количество строк (не больше 9): ");
int cols = ReadInt("Введите количество столбцов (не больше 9): ");
bool sizeRestrictions = false;

while (!sizeRestrictions)
{
    if (cols >= 0 && cols < 10 && rows >= 0 && rows < 10)
    {
        sizeRestrictions = true;
    }
    else
    {
        Console.WriteLine("Некорректный ввод!");
        rows = ReadInt("Введите количество строк (НЕ БОЛЬШЕ 9): ");
        cols = ReadInt("Введите количество столбцов (НЕ БОЛЬШЕ 9): ");
    }
}

int[,] numbers = new int[rows, cols];

FillArray2D(numbers);
PrintArray2D(numbers);

Console.WriteLine("Введите предполагаемые индексы через пробел: ");
string userInput = Console.ReadLine();

userInput = NoExcessSpaces(userInput);
int index1 = Convert.ToInt32(Char.ToString(userInput[0]));
int index2 = Convert.ToInt32(Char.ToString(userInput[2]));
bool outOfRange = index1 > rows || index2 > cols;

if (outOfRange)
{
    Console.WriteLine("Такого элемента нет.");
}
else
{
    Console.WriteLine(numbers[index1, index2]);
}
