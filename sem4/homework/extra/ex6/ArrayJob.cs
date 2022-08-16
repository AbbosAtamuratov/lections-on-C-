// Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – 
// первая добавляет к числовому массиву значение, тем самым увеличивая массив, 
// а вторая удаляет элемент под нужным индексом и уменьшает массив на 1.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++) Console.Write(a[i] + " ");
    Console.WriteLine("");
}

int[] CreateArray(int size)
{
    int[] a = new int[size];
    for (int i = 0; i < a.Length; i++) a[i] = new Random().Next(0, 100);
    return a;
}

int[] AddToArray(int[] A)
{
    int modifier = ReadInt("Введите значение, на которое вы хотите увеличить массив: ");
    int[] result = new int[A.Length + modifier];
    for (int i = 0; i < A.Length; i++) result[i] = A[i];
    for (int j = A.Length; j < A.Length + modifier; j++)
    {
        result[j] = ReadInt($"Введите значение нового элемента на {j + 1}й позиции: ");
    }
    return result;
}

int FindTargetIndex(int[] B, int target)
{
    int i=0;
    while (B[i] != target && i < B.Length)
    {
        i++;
    }
    return i;
}

int[] CutOutOfArray(int[] A)
{
    int target = ReadInt("Введите значение элемента, которое надо удалить: ");
    int castawayIndex = FindTargetIndex(A, target);
    int[] result = new int[A.Length - 1];
    for (int i = 0; i < result.Length; i++)
    {
        if (i == castawayIndex)
        {
            result[i] = A[i+1];
        }
        else
        {
            result[i] = A[i];
        }
    }
    return result;
}

int initialSize = ReadInt("Введите размер случано генерируемого массива: ");
int[] array = CreateArray(initialSize);
PrintArray(array);
int[] expanded = AddToArray(array); 
PrintArray(expanded);
PrintArray(CutOutOfArray(expanded));