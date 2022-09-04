//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman (int m, int n)
{
    if (m==0 && n>0)
        return n+1;
    else if (n==0 && m>0)
        return Akkerman(m-1, 1);
    else if (m>0 && n>0)
        return Akkerman(m-1,Akkerman(m, n-1));
    else
        return n+1;
}

int number1 = ReadInt("Введите число: ");
int number2 = ReadInt("Введите 2e число: ");
Console.Write (Akkerman(number1, number2));