Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
{
    max = b;
    if (c > max)
    {
        Console.WriteLine("Число " + c + " самое большое ");
    }
    else
    {
        Console.WriteLine("Число " + b + " самое большое ");
    }
}
else
{
    if (c > a)
    {
        Console.WriteLine("Число " + c + " самое большое ");
    }
    else
    {
        Console.WriteLine("Число " + a + " самое большое ");
    }
}