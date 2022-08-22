// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
 
int size = ReadInt("Введите размер массива: ");
int[] array = new int[size];
FillArrayRandomNumbers(array);
PrintArray(array);
Reverse(array);
PrintArray(array); 

/*----------------------------------------------------------*/
 void Reverse(int[] array1)
{
    int temp = 0;
    for (int i = 0; i < array1.Length / 2; i++)
    {
        temp = array1[i];
        array1[i] = array1[array1.Length - 1 - i];
        array1[array1.Length - 1 - i] = temp;
    }
}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 201);
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}