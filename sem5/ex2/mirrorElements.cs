// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
//на соответствующие отрицательные, и наоборот.

int size = ReadInt("Введите размер массива: ");
int[] array = new int[size];
FillArrayRandomNumbers(array);
PrintArray(array);
MirrorArray(array);
PrintArray(array);


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

void MirrorArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        array1[i]  *= (-1);
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i]+ " ");
    Console.WriteLine();
}