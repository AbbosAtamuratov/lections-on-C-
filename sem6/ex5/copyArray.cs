int size = ReadInt("Укажите длину массива: ");
int[] array = new int[size];
int[] newArray = new int[array.Length];

FillArrayRandomNumbers(array);
PrintArray(array);

for(int i = 0; i < array.Length; i++)
{
    newArray[i] = array[i];
}

PrintArray(newArray);

void FillArrayRandomNumbers(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        array1[i] = new Random().Next(0, 10);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
    Console.WriteLine();
}
