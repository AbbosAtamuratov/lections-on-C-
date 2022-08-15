// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// no string allowed
 int ReadInt(string msg)
 {
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
 }

int number = ReadInt ("Введите число: ");
int click = 0;
while(number>0)
{
    number /= 10;
    click++;
}

Console.Write($"В вашем числе {click} цифр.");