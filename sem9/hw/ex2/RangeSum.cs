// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int RangeSum (int n, int m)
{
    
    if (m == n)
        return m;
    else 
    {
        int sum = m;
        sum+=RangeSum(n, m -1);
        return sum;
    }
}

int number1 = ReadInt("Введите число: ");
int number2 = ReadInt("Введите 2e число: ");
Console.Write(RangeSum(number1, number2));