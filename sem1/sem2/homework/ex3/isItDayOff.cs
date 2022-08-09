//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//  и проверяет, является ли этот день выходным
Console.Clear();

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool DayOff (int a)
{
    bool res = (a == 6) || (a == 7);
    return res;
}

int day = ReadInt("Введите число от 1 до 7, обозначающее день: ");

while (day >= 8)
{
    day = ReadInt("Некорректный ввод, попробуй ещё раз: ");
}

if (DayOff(day) == true)
{
    Console.Write("Это выходной");
}
else
{
    Console.Write("Это не выходной");
}