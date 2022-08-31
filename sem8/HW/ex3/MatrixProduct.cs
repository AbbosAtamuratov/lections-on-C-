// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumProducts(int[] a, int[] b)
{
    int res=0;
    for (int i = 0; i < a.Length; i++)
        res+= a[i]*b[i];
    return res;
}

int[] GetMatrixRow (int[,] array, int rowNumber)
{
    int[] res = new int[array.GetLength(1)];
    for (int i = 0; i < res.Length; i++)
        res[i] = array[rowNumber, i];
    return res;
}

int[] GetMatrixCol (int[,] array, int colNumber)
{
    int[] res = new int[array.GetLength(0)];
    for (int i = 0; i < res.Length; i++)
        res[i] = array[i, colNumber];
    return res;
}

/*----------------------MAIN----------------------------------*/

int matrixNumber = 1;
int rows1 = ReadInt($"Введите количество строк в {matrixNumber}й матрице: ");
int columns1 = ReadInt($"Введите количество столбцов в {matrixNumber}й матрице: ");
int[,] matrix1 = new int[rows1, columns1];

matrixNumber++;
int rows2 = ReadInt($"Введите количество строк в {matrixNumber}й матрице: ");
int columns2 = ReadInt($"Введите количество столбцов в {matrixNumber}й матрице: ");
int[,] matrix2 = new int[rows2, columns2];

FillArray2D(matrix1);
PrintArray2D(matrix1);

FillArray2D(matrix2);
PrintArray2D(matrix2);


if (columns1 != rows2)
{
    Console.WriteLine ("Матрицы НЕ СОГЛАСОВАНЫ"+
        ". Операция умножения двух матриц выполнима ТОЛЬКО в том случае, если число столбцов в первом сомножителе равно числу строк во втором.");
    return;
}

int[,] resultMatrix = new int[rows1, columns2];
int[] matrix1Row = new int[matrix1.GetLength(0)];
int[] matrix2Col = new int[matrix2.GetLength(1)];

for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {       
        matrix1Row = GetMatrixRow(matrix1,i); 
        for (int l = 0; l < resultMatrix.GetLength(1); l++)
        {
            matrix2Col = GetMatrixCol(matrix2, l);
            resultMatrix[i,l] = SumProducts(matrix1Row, matrix2Col);   
        }
    }

PrintArray2D(resultMatrix);