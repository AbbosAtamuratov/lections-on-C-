// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
//выдаёт номер четверти плоскости, в которой находится эта точка.

int x = ReadInt("Введите X: ");
int y = ReadInt("Введите Y: ");

if(x == 0 || y == 0)
{
    Console.WriteLine("Номер четверти определить не удалось");
    return;
}

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка в 1 четверти");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Точка во 2 четверти");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Точка в 3 четверти");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Точка в 4 четверти");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

