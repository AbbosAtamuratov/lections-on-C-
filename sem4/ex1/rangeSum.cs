//  Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
int sum = 0;

while (index <= number)
{
    sum += index++;
}
Console.WriteLine(sum);
