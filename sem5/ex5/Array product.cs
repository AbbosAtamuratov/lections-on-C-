// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomNumbers(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        array1[i] = new Random().Next(0, 10);
}

void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
    Console.WriteLine();
}

int GetSize(int[] array1)
{
    if (array1.Length %2 == 0)
        return array1.Length/2;
    else 
        return (array1.Length/2)+1;
}

int[] ArrayProduct(int[] array1)
{
    int resSize = GetSize(array1);
    int[] resultArray = new int[resSize];
    if (array1.Length %2 == 0)
    {
        for (int i=0; i<resSize; i++)
            resultArray[i] = array1[i] * array1[array1.Length-1-i];
    }
    else
    {
        for (int j=0; j<resSize; j++)
            resultArray[j] = array1[j] * array1[array1.Length-1-j];
        resultArray[resSize-1] = array1[((array1.Length-1)/2)];
    }
    return resultArray;
}

int size = ReadInt("Введите размер массива: ");
int[] array = new int[size];
FillArrayRandomNumbers(array);
PrintArray(array);
PrintArray(ArrayProduct(array));
