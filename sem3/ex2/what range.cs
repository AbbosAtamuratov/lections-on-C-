// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

int numberQuarter = ReadInt("Введите номер Четверти: ");

if(numberQuarter == 1)
{
    Console.Write("Возможный диапазон X от 0 до бесконечности, Y от 0 до бесконечности.");
}
else if(numberQuarter == 2)
{
    Console.Write("Возможный диапазон X от 0 до -бесконечности, Y от 0 до бесконечности.");
}
else if(numberQuarter == 3)
{
    Console.Write("Возможный диапазон X от 0 до -бесконечности, Y от 0 до -бесконечности.");
}
else if(numberQuarter == 4)
{
    Console.Write("Возможный диапазон X от 0 до бесконечности, Y от 0 до -бесконечности.");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
