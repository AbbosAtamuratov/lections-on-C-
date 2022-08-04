Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>999 || number<100)
{
    Console.WriteLine("Некорректный ввод");
}
else
{
Console.WriteLine("Результат: " + number%10);
}