//  Напишите программу, которая задаёт массив из N элементов и выводит их на экран

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray (int[] a)
{
    for (int i=0; i<a.Length; i++) Console.Write(a[i]+" ");
}

int[] CreateArray (int size)
{
    int[] a = new int[size];
    for (int i=0; i<a.Length; i++) a[i] = new Random().Next(0, 100);
    return a;
}

PrintArray(CreateArray(ReadInt("Введите размер желаемого массива: ")));