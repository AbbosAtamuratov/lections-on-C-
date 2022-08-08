// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int randomNumber = GetRandomNumber(10, 99);
Console.WriteLine(randomNumber);

int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;

int maxDigit = Max(firstDigit, secondDigit);
Console.WriteLine(maxDigit);

int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int Max(int a, int b)
{
    int max = 0;
    if(a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
    return max;
}
