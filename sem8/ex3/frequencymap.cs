// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
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

int CountMathes(int[] array1, int target)
{
    int counter = 0;
    for (int j = 0; j < array1.Length; j++)
    {
        if (array1[j] == target)
            counter++;
    }
    return counter;
}

int[] Spagettify(int[,] array1)
{
    int[] result = new int[array1.GetLength(0) * array1.GetLength(1)];
    int k=0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            result[k] = array1[i,j];
            k++;
        }
    }
    return result;
}

void SortAscend(int[] array1)
{
    for (int i = 0; i < array1.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array1.Length; j++)
        {
            if (array1[j] < array1[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array1[i];
        array1[i] = array1[minPosition];
        array1[minPosition] = temporary;
    }
}

string CutOutClones (int[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length-1; i++)
    {
        if(array[i] != array[i+1])
            result = array[i] + " " + result;
    }
    result = result.Trim(' ');
    return result;
}

int CountSpaces(string convertedArray)
{
    int counter = 0;
    for (int i = 0; i < convertedArray.Length; i++)
    {
        if (convertedArray[i] == ' ')
            counter++;
    }
    return counter;
}

int[] BackToArray(string convertedArray)
{
    int size = CountSpaces(convertedArray)+1;
    int[] result = new int[size];
    string[] splitted = convertedArray.Split(' ', size);
    for (int i =0; i<size; i++)
        result[i] = Convert.ToInt32(splitted[i]);
    return result;
}

/*----------MAIN--------------*/

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, cols];

FillArray2D(numbers);
PrintArray2D(numbers);

int mapSize = rows * cols;
int[,] map = new int[2, mapSize];

int[] allNumbers = Spagettify(numbers);
PrintArray(allNumbers);
Console.WriteLine();
Console.WriteLine();

SortAscend(allNumbers);
string temp = CutOutClones(allNumbers);
int[] result = BackToArray(temp);

for (int i = 0; i < allNumbers.Length; i++)
{
    map[0, i] = allNumbers[i];
    map[1, i] = CountMathes(allNumbers, allNumbers[i]);
}

PrintArray2D(map);

/*-----------Denis-------*/
// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int[,] numbers = new int[rows, columns];
// FillArray(numbers);
// PrintArray(numbers);

// SortArray(numbers);
// PrintArray(numbers);

// int countMatches = 1;
// int temp = numbers[0, 0];
// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         if(temp != numbers[i, j])
//         {
//             temp = numbers[i, j];
//             countMatches++;
//         }
//     }
// }

// int[,] frequencyDictionary = new int[2, countMatches];

// int frequencyDictionaryIndex = 0;
// frequencyDictionary[0, frequencyDictionaryIndex] = numbers[0, 0];
// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         if(frequencyDictionary[0, frequencyDictionaryIndex] == numbers[i, j])
//         {
//             frequencyDictionary[1, frequencyDictionaryIndex]++;
//         }
//         else
//         {
//             frequencyDictionaryIndex++;
//             frequencyDictionary[0, frequencyDictionaryIndex] = numbers[i, j];
//             frequencyDictionary[1, frequencyDictionaryIndex]++;
//         }
//     }
// }

// for (int i = 0; i < frequencyDictionary.GetLength(1); i++)
// {
//     Console.WriteLine($"Число {frequencyDictionary[0, i]} встречается {frequencyDictionary[1, i]} раз");
// }
// void SortArray(int[,] array)  //сортируем массив от максимума к минимуму
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(0); k++)
//             {
//                 for (int l = 0; l < array.GetLength(1); l++)
//                 {
//                     if (array[k, l] < array[i, j])
//                     {
//                         int temp = array[i, j];
//                         array[i, j] = array[k, l];
//                         array[k, l] = temp;
//                     }
//                 }
//             }
//         }
//     }
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("\n");
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

/*----Maxim----*/
// void PrintArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j]+" ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine("Введите количество строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows,columns];
// for (int i=0; i<rows; i++)
// {
//     for (int j=0; j<columns; j++)
//     {
//         array[i, j] = new Random().Next(1, 10);
//     }
// }
// PrintArray(array);
// int max = array[0, 0];
// for (int i=0; i<rows; i++)
// {
//     for (int j=0; j<columns; j++)
//     {
//         if (array[i, j] > max) max = array[i, j];
//     }
// }
// int[] counter = new int[max];
// for (int i=0; i<rows; i++)
// {
//     for (int j=0; j<columns; j++)
//     {
//         counter[array[i, j]-1] += 1;
//     }
// }
// for (int i=0; i<counter.Length; i++)
// {
//     if (counter[i] == 0) continue;
//     Console.WriteLine($"Число {i+1} встречается {counter[i]} раз(а)");
// }
