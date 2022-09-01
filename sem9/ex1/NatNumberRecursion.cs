//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumber(number + 2);

int NaturalNumber(int n)
{
    if(n <= 2)
        return 1;
    else
    {
        n--;
        Console.Write(NaturalNumber(n) + " ");
    }

    return n;
}

//  вызов->печать
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write(NaturalNumber(number));

// int NaturalNumber(int n)
// {
//     if(n == 1)
//         return 1;
//     else
//     {
//         Console.Write(NaturalNumber(n - 1) + " ");
//     }

//     return n;
// }

// войд метод
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// NaturalNumber(number);

// void NaturalNumber(int n)
// {
//     if(n == 1)
//         Console.Write(n + " ");
//     else
//     {
//         NaturalNumber(n - 1);
//         Console.Write(n + " ");
//     }
// }
