// Написать 2 функции для работы с массивом: AddToArray И RemoveFromArray – 
// первая добавляет к числовому массиву значение, тем самым увеличивая массив, 
// а вторая удаляет элемент под нужным индексом и уменьшает массив на 1.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
         Console.Write(array[i] + " ");
    Console.WriteLine("");
}

int[] CreateArray(int size)
{
    int[] a = new int[size];
    for (int i = 0; i < a.Length; i++) 
        a[i] = new Random().Next(0, 100);
    return a;
}

int[] AddToArray(int[] array, int value)
{
    int[] result = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++) 
        result[i] = array[i];     
    result[result.Length-1] = value;
    return result;
}

int FindTargetIndex(int[] array, int target)
{
    int i=0;
    while (array[i] != target && i < array.Length)
    {
        i++;
    }
    return i;
}

int[] CutOutOfArray(int[] array, int index)
{
    int[] result = new int[array.Length - 1];
    for (int i = 0; i<index; i++) 
        result[i] = array[i];
    for (int j = index; j<result.Length; j++) result[j] = array[j+1];
    return result;
}

int initialSize = ReadInt("Введите размер случано генерируемого массива: ");
int[] array = CreateArray(initialSize);
PrintArray(array);
int newNumber = new Random().Next(0, 100);
int[] expanded = AddToArray(array,newNumber); 
Console.WriteLine("Добавляем ячейку в массив:");
PrintArray(expanded);
int target = ReadInt("Введите значение элемента, которое надо удалить: ");
int castawayIndex = FindTargetIndex(expanded, target);
PrintArray(CutOutOfArray(expanded, castawayIndex));
