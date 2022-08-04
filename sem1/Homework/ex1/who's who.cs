// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.WriteLine("Число " + a + " больше " + b);
}
else
{
   if (a == b)
   {
        Console.WriteLine("Число " + b + " равно " + a);
   }
   else
   {
        Console.WriteLine("Число " + b + " больше " + a);
   }
}