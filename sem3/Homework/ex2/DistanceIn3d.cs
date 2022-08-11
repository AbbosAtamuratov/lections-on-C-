// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

int ReadInt (string UImsg)
{
    Console.Write (UImsg);
    return Convert.ToInt32(Console.ReadLine());
}

int [] dotMe (int a, int b, int c)
{
    int[] dot = new int[3];
    dot[0] = a;
    dot[1] = b;
    dot[2] = c;
    return dot;
}

double Distance3D (int[] A, int[] B)
{
    int lenX = A[0]-B[0];
    int lenY = A[1]-B[1];
    int lenZ = A[2]-B[2];
    return Math.Sqrt(lenX*lenX+lenY*lenY+lenZ*lenZ);
}

string PrintDot (int[] a)
{
    return ($"({a[0]}; {a[1]}; {a[2]})");
}

int[] firstDot = new int[3];
int[] secondDot = new int[3];
int x1 = ReadInt("Введите Х для 1й точки: ");
int y1 = ReadInt("Введите Y для 1й точки: ");
int z1 = ReadInt("Введите Z для 1й точки: ");
int x2 = ReadInt("Введите Х для 2й точки: ");
int y2 = ReadInt("Введите Y для 2й точки: ");
int z2 = ReadInt("Введите Z для 2й точки: ");

firstDot = dotMe(x1, y1, z1);
secondDot = dotMe(x2, y2, z2);

Console.Write ("Расстояние между вашими точками");
Console.Write ($" A{PrintDot(firstDot)} и B{PrintDot(secondDot)} равняется {Distance3D(firstDot, secondDot)}");