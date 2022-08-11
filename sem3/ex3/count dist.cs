// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int CheckLength (int a, int b)
{
    return b-a;
}

double dXdY (int a, int b)
{
    double sqrRes = Convert.ToDouble (a*a+b*b);
    return Math.Sqrt (sqrRes);
}

int x1 = ReadInt("Введите координату Х первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int x2 = ReadInt("Введите координату Х второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");

int xLength = CheckLength(x1, x2);
int yLength = CheckLength(y1, y2);

double result = dXdY(xLength, yLength);

Console.WriteLine("Расстояние между вашими точками: " + result);