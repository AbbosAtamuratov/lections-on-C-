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
    int[] result = new int[3];
    result[0] = ReadInt($"Введите значение k{order}:");
    result[1] = -1;
    result[2] = ReadInt($"Введите значение b{order}:");
    return result;
}

/* используем метод Крамера для получения точки пересечения линий 
представляем у=kx+b как kx-y+b=0
получаем 3 матрицы
дельта,     дельта по х и дельта по у
|k1  -1|    |b1  -1|       |k1  b1|
|k2  -1|    |b2  -1|       |k2  b2|
где -1 это коэффицент перед у.
координата х точки пересечения равна модулю матрицы дельта по х делить на модуль матрицы дельта
координата у точки пересечения равна модулю матрицы дельта по у делить на модуль матрицы дельта

это значит что если модуль матрицы делта равен нулю, то решений нет, а это возможно когда k1=k2, 
что в свою очередь значит, что линии параллельны.
Модуль матрицы равен 1й 4й минус 2й элемент умножить на 3й
|1  2|
|3  4|
*/

int[] line1 = DefineLine("Зададим первую линию фунцией у = k1 * x + b1 ", 1);
int[] line2 = DefineLine("Зададим вторую линию фунцией у = k2 * x + b2 ", 2);

if (line1[0] == line2[0])
{
    Console.WriteLine("Линии параллельны.");
    return;
}
int delta = line1[0]*line2[1] - line1[2]*line2[0];
int deltaX = line1[2]*line2[1] - line1[1]*line2[2];
int deltaY = line1[0]*line2[2] - line1[2]*line2[0];
double x = deltaX/delta;
double y = deltaY/delta;
Console.WriteLine($"Линии пересекутся в точке ({Math.Round(x,2)}, {Math.Round(y,2)})");