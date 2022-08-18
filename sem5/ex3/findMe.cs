// See https://aka.ms/new-console-template for more information
int size = ReadInt("Введите размер массива: ");
int[] array = new int[size];
FillArrayRandomNumbers(array);
PrintArray(array);
int number = ReadInt("Введите число которое нужно найти: ");

if (FindMe(array, number))
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        array1[i] = new Random().Next(-9, 10);
}

bool FindMe(int[] array1, int target)
{
    bool result = false;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] == target) result = true;
    }
    return result;
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
    Console.WriteLine();
}
