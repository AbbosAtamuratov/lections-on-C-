// Написать функцию Shuffle, которая перемешивает элементы массива в случайном порядке.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array1, int min, int max)
{
    for (int i = 0; i < array1.Length; i++)
        array1[i] = new Random().Next(min, max);
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
    Console.WriteLine("\n");
}

void Shuffle(int[] array1)
{
    int temp = 0;
    int randomPosition =0;
    for (int i = 0; i < array1.Length; i++)
    {
        randomPosition = new Random().Next(0, array1.Length);
        temp = array1[i];
        array1[i] = array1[randomPosition];
        array1[randomPosition]=temp;
    }
}

int size = ReadInt("Введите размер массива: ");
int[] array = new int[size];
int min = 1;
int max = 21;
FillArrayRandomNumbers(array, min, max);
PrintArray(array);
Shuffle(array);
PrintArray(array);