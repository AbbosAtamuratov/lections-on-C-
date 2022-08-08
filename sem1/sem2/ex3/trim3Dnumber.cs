/*Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.*/

int GetRandomNumber(int a, int b)
{
    return new Random().Next(a, b);
}

int GetLastDigit (int a)
{
    return a % 10;
}

int GetFirstDigit (int a)
{
    return a / 100;
}

int number = GetRandomNumber(100, 1000);
Console.WriteLine(number);
Console.Write(GetFirstDigit(number));
Console.Write(GetLastDigit(number));