//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int A = ReadInt("Введите число возводимое в степень: ");
int B = ReadInt("В какую степень возвести? ");
int result = 1;

for (int i = 0; i < B; i++) result *= A;

Console.WriteLine($"{A} в степени {B} получается {result}");