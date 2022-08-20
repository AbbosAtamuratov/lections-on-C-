// факториал
double Factorial(int number)
{
    if (number ==1) return 1;
    else return number*Factorial(number-1);
}

for (int i=1; i<8; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
