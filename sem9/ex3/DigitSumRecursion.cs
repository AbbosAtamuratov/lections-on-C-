// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int DigitSum (int number)
{
    if (number < 10 ) 
        return number;
    else
    {
        int sum = number % 10; 
        sum += DigitSum(number/10);
        return sum;
    } 
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int n = ReadInt("Введите число: ");
Console.Write ($"Cумма чисел в вашем числе: {DigitSum(n)}");