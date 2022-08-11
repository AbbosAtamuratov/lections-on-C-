// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Sqr(int a)
{
    return a * a;
}

void SqrRange(int a)
{
    int number = 1;
    Console.Write("Ваша последовательность: ");
    while (number <= a)
    {
        Console.Write(Sqr(number) + " ");
        number++;
    }
}

int a = ReadInt("Введите число: ");
SqrRange(a);