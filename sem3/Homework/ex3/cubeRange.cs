// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int cube(int a)
{
    return a * a * a;
}

void CubeRange(int a)
{
    int number = 1;
    Console.Write("Ваша последовательность: ");
    while (number <= a)
    {
        Console.Write(cube(number) + " ");
        number++;
    }
}

int a = ReadInt("Введите число: ");
CubeRange(a);
