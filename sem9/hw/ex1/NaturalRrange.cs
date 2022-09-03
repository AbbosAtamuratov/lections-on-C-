// Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NaturalReverseRange(int n)
{
    if (n <= 2) 
        return 1;
    else
    {

        n--;
        Console.Write ($"{n} ");
        n=NaturalReverseRange(n);
    }
    return n;
}


int number = ReadInt("Введите число: ");
Console.Write ($"{NaturalReverseRange(number+1)} ");
