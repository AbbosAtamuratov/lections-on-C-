// See https://aka.ms/new-console-template for more information

int number = ReadInt("Введите число ");
int result = 1;

for (int i = 1; i <= number; i++)
{
    result *= i;
}

Console.WriteLine(result);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

