Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int number = 2;
if (a<0)
{
    Console.Write("Введите ПОЛОЖИТЕЛЬНОЕ число или программа завершится: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (a == 1)
    {
        Console.Write("В промежутке от 1 до вашего числа чётных чисел нет");
    }
    else
    {
        while (number <= a)
        {
            Console.Write(number+" ");
            number+=2 ;
        }
    }
}
else
{
    if (a == 1)
    {
        Console.Write("В промежутке от 1 до вашего числа чётных чисел нет");
    }
    else
    {
        while (number <= a)
        {
            Console.Write(number+" ");
            number+=2 ;
        }
    }
}