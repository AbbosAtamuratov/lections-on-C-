Console.WriteLine("Введите целое чисо: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = (-1) * number;
while (a <= number)
{
    Console.Write(a+" ");
    a++ ;
}