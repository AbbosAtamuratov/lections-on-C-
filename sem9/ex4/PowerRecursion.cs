// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double Power (int n, int p)
{
    if (p==0)
        return 1;
    else
    {
        double res = 1;
        p--;
        res = n * Power(n,p);
        return res;
    }
}

int number = ReadInt("Введите число: ");
int power = ReadInt("Введите степень, в которую надо возвести: ");
Console.WriteLine($"{number} в степени {power} равно {Power(number,power)}");