// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

int NaturalRange(int min, int max)
{
    if (min > max)
    {
        int temp = max;
        max = min;
        min = temp;
    }

    
        if (max == min)
            return min;
        else
        {
            Console.Write($"{NaturalRange(min, max - 1)} ");
        }
        return max;
    
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int m = ReadInt("Введите минимальное значение в ряду: ");
int n = ReadInt("Введите максимальное значение в ряду: ");

Console.Write(NaturalRange(m, n) + " ");