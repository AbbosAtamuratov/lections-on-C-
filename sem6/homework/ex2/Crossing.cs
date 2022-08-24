// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] DefineLine(string message, int order)
{
    Console.WriteLine(message);
    int[] result = new int[2];
    result[0] = ReadInt($"Введите значение k{order}:");
    result[1] = ReadInt($"Введите значение b{order}:");
    return result;
}


int[] line1 = DefineLine("Зададим первую линию фунцией у = k1 * x + b1 ", 1);
int[] line2 = DefineLine("Зададим вторую линию фунцией у = k2 * x + b2 ", 2);

if (line1[0] == line2[0])
{
    Console.WriteLine("Линии параллельны.");
    return;
}

if (line1[1] == line2[1])
{
    Console.WriteLine($"Линии пересекутся в точке ({0}, {line1[1]})");
    return;
}

double x = (line1[1] - line2[1]) / (line2[0] - line1[0]);
double y = ((line1[0]+line2[0])*x+line1[1]+line2[1])/2;
Console.WriteLine($"Линии пересекутся в точке ({x}, {y})");
