//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SumMeMath(int a, string msg)
{
    int sum = 0;
    while (a > 0)
    {
        sum += a % 10;
        a /= 10;
    }
    Console.WriteLine($"Cумма цифр равна {sum}. ({msg})");
}

void SumMeString(string input, string msg)
{
    int res = 0;
    string[] a = new string[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        a[i] = input[i].ToString();
        res += Convert.ToInt32(a[i]); 
    }
    Console.WriteLine($"Cумма цифр равна {res}. ({msg})");
}

int number = ReadInt("Введите число: ");
string numero = Convert.ToString(number);

SumMeMath(number, "Математическим методом");
SumMeString(numero, "Строчным методом");