// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

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

int number = ReadInt("Введите число: ");
int size = 0;
int temporary = number;
while (temporary > 0)
{
    temporary /= 2;
    size++;
}
int[] result = new int [size];

for (int i=0; i<size; i++)
{
    result[i]= number % 2;
    number/=2;
}

Console.WriteLine ("Ваше число в двоичной системе:\n");
Reverse(result);
PrintArray(result);
