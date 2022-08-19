// Написать программу со следующими командами:
// - SetNumbers – пользователь вводит числа через пробел, а программа запоминает их в массив
// - AddNumbers – пользователь вводит числа, которые добавятся к уже существующему массиву
// - RemoveNumbers -  пользователь вводит числа, которые если  найдутся в массиве, то будут удалены
// - Numbers – ввывод текущего массива
// - Sum – найдется сумма всех элементов чисел
// Список команд можно дополнить по своему желанию. Все они должны быть направлены на работу с числовым массивом.

// int[] array = ReadIntArray("Введите элементы массива через пробел: ");
// PrintArray(array);

string test = ReadStr("Введите строку: ");

/*-------------------------------------------------------------------*/
string ReadStr(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

int CountSpaces(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ' ')
            counter++;
    return counter;
}

int[] ReadIntArray(string message)
{
    Console.Write(message);
    string input = Console.ReadLine();
    int[] result = new int[CountSpaces(input) + 1];
    int cursor = 0;
    string temp = "";
    int resultIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            temp = input.Substring(cursor, i - cursor);
            result[resultIndex] = Convert.ToInt32(temp);
            cursor = i;
            resultIndex++;
        }
    }
    return result;
}

void PrintArray(int[] array1)
{
    Console.Write("Ваш массив: ");
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
    Console.WriteLine("\n");
}

void Shuffle(int[] array1)
{
    int temp = 0;
    int randomPosition = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        randomPosition = new Random().Next(0, array1.Length);
        temp = array1[i];
        array1[i] = array1[randomPosition];
        array1[randomPosition] = temp;
    }
}

void Reverse(int[] array1)
{
    int temp = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        temp = array1[i];
        array1[i] = array1[array1.Length - 1 - i];
        array1[array1.Length - 1 - i] = temp;
    }
}

void Sum(int[] array1)
{
    int result = 0;
    for (int i = 0; i < array1.Length; i++)
        result += array1[i];
    Console.WriteLine($"Сумма всех элементов равна: {result}.");
}

void SumUneven(int[] array1)
{
    int result = 0;
    for (int i = 0; i < array1.Length; i += 2)
        result += array1[i];
    Console.WriteLine($"Сумма всех нечётных элементов равна: {result}.");
}

void SumEven(int[] array1)
{
    int result = 0;
    for (int i = 1; i < array1.Length; i += 2)
        result += array1[i];
    Console.WriteLine($"Сумма всех чётных элементов равна: {result}.");
}

void Average(int[] array1)
{
    double result = 0;
    for (int i = 0; i < array1.Length; i++)
        result += array1[i];
    result = Math.Round(result / array1.Length, 2);
    Console.WriteLine($"Среднее арифметическое от элментов массива равно: {result}.");
}

void MinMax(int[] array1)
{
    int result = 0;
    int min = array1[0];
    int max = array1[0];
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > max) max = array1[i];
        if (array1[i] < min) min = array1[i];
    }
    result = max - min;
    Console.WriteLine($"Разница между максимальным и значениями равна: {result}.");
}

void MinMaxDistance(int[] array1)
{
    int result = 0;
    int min = array1[0];
    int max = array1[0];
    int imin = 0;
    int imax = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] > max) imax = i;
        if (array1[i] < min) imin = i;
    }
    result = imax - imin;
    Console.WriteLine($"Максимальое значение в массиве находится на расстоянии в {result} элементов от минимального.");
}

void CommandList()
{
    Console.WriteLine("Список команд:");
    Console.WriteLine("GenerateArray – запоминает числа, введённые через пробел, как массив");
    Console.WriteLine("AddNumbers – добавляет числа, введённые через пробел, к уже существующему массиву");
    Console.WriteLine("RemoveNumbers – числа, введённые через пробел, удаляются из уже существующего массива, если такие есть");
    /**/
    Console.WriteLine("Numbers – печатает текущий массив");
    /**/
    Console.WriteLine("Shuffle – случайным образом перемешивает элементы текущего массива");
    /**/
    Console.WriteLine("Sum – суммирует элементы текущего массива");
    /**/
    Console.WriteLine("SumEven – суммирует чётные элементы текущего массива");
    /**/
    Console.WriteLine("SumUneven – суммирует нечётные элементы текущего массива");
    /**/
    Console.WriteLine("Reverse – разворачивает текущий массив");
    Console.WriteLine("SortAscend – сортирует текущий массив по возрастанию");
    Console.WriteLine("SortDecend – сортирует текущий массив по убыванию");
    /**/
    Console.WriteLine("Mirror – меняет знак элементов текущего массива");
    /**/
    Console.WriteLine("MinMax – находит разницу между максимальным и минмальным элементами текущего массива");
    /**/
    Console.WriteLine("MinMaxDistance – находит расстояние между максимальным и минмальным элементами текущего массива");
    /**/
    Console.WriteLine("Average – среднее арифметическое элементов текущего массива");
    /**/
    Console.WriteLine("Exit – завершает работу программы\n");
}