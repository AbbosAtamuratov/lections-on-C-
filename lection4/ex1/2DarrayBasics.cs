// See https://aka.ms/new-console-template for more information
int[,] matrix = new int[3, 3];
Print2Darray(matrix);
Console.Write("\n");
Fill2Darray(matrix);
Print2Darray(matrix);

void Print2Darray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("\n");
    }
}

void Fill2Darray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }
        Console.Write("\n");
    }
}