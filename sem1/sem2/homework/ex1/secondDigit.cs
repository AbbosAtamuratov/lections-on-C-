// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Clear();
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Get2ndDigit(int a)
{
    int res = (a / 10) - ((a / 100) * 10);
    return res;
}

bool isIt3Digit (int a)
{
    bool i = (a > 99) && (a < 1000);
    return i; 
}

int number = ReadInt("Введите 3х-значное число: ");
bool j=false;
while (j == false)
{
    if (isIt3Digit(number) == j)
    {
        number = ReadInt("Некорректный ввод. Введите 3х-значное число: ");
    }
    else
    {
        Console.WriteLine("Ваше число: " + Get2ndDigit(number));
        j = true;
    }
} 