// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
Console.WriteLine("Введите первое число:");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondnumber = Convert.ToInt32(Console.ReadLine());

bool IsItX(int a, int b)
{
    bool i = true;
    if (a % b == 0)
    {
        i = true;
    }
    else
    {
        i = false;
    }
    return i;
}

if (IsItX(firstnumber, secondnumber))
{
    Console.WriteLine("Число " + firstnumber + " кратно " + secondnumber);
}
else
{
    Console.WriteLine("Остаток от деления ваших чисел: " + (firstnumber % secondnumber));
}

// тело функции IsItX можно сократить до return a%b==0;
/* также можно оптимизтровать пользовательский ввод функцией

int ReadInt(string message)
{
    Console.Write(message);   
    return Convert.ToInt32(Console.ReadLine());
}
 
 а затем просто писать ReadInt("Введите число: ") */