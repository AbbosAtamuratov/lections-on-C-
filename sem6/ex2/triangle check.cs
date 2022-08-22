// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
//треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool TriangleCheck (int num1, int num2, int num3)
{
    if (num1+num2>num3 && num2+num3>num1 && num1+num3>num2)
        return true;
    else return false;
}
int[] candidates = new int [3];
for (int i=0; i<3; i++)
    candidates[i] = ReadInt($"Ведите {i+1}e число: ");
if (TriangleCheck(candidates[0], candidates[1],candidates[2]))
    {
        Console.WriteLine("Это треугольник");
    }
    else
    {
        Console.WriteLine("Такого треугольника не может быть.");
    }