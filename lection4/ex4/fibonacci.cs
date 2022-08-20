// Fibonacci 

int Fibonacci(int n)
{
    if (n == 1 || n==2) return 1;
    else return Fibonacci(n-2)+Fibonacci(n-1);
}

for (int i = 1; i<10; i++)
{
    Console.WriteLine(Fibonacci(i));
}