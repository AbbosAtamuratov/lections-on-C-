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
    for (int i = 0; i < a.Length; i++) 
                Console.Write(a[i] + " ");
    Console.WriteLine("");
}

int[] CreateArray(int size)
{
    int[] a = new int[size];
    for (int i = 0; i < a.Length; i++) a[i] = new Random().Next(0, 100);
    return a;
}

int[] AddToArray(int[] a)
{
    int[] result = new int[a.Length + 1];
    for (int i = 0; i < a.Length; i++) result[i] = a[i];
    for (int j = a.Length; j < a.Length + 1; j++)
    {
        result[j] = new Random().Next(0, 100);
    }
    return result;
}

int FindTargetIndex(int[] b, int target)
{
    int i=0;
    while (b[i] != target && i < b.Length)
    {
        i++;
    }
    return i;
}

int[] CutOutOfArray(int[] a)
{
    int target = ReadInt("Введите значение элемента, которое надо удалить: ");
    int castawayIndex = FindTargetIndex(a, target);
    int[] result = new int[a.Length - 1];
    for (int i = 0; i<castawayIndex; i++) result[i] = a[i];
    for (int j = castawayIndex; j<result.Length; j++) result[j] = a[j+1];
    return result;
}

int initialSize = ReadInt("Введите размер случано генерируемого массива: ");
int[] array = CreateArray(initialSize);
PrintArray(array);
int[] expanded = AddToArray(array); 
PrintArray(expanded);
PrintArray(CutOutOfArray(expanded));
