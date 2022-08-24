// Написать программу со следующими командами:
// - SetNumbers – пользователь вводит числа через пробел, а программа запоминает их в массив
// - AddNumbers – пользователь вводит числа, которые добавятся к уже существующему массиву
// - RemoveNumbers -  пользователь вводит числа, которые если  найдутся в массиве, то будут удалены
// - Numbers – ввывод текущего массива
// - Sum – найдется сумма всех элементов чисел
// Список команд можно дополнить по своему желанию. Все они должны быть направлены на работу с числовым массивом.

Console.Clear();

int[] range = SetNumbers("Введите элементы массива через пробел: ");
PrintArray(range);
int[] shortRange = RemoveNumbers(range);
PrintArray(shortRange);


/*------------------------METHODS---------------------------------------------*/
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
/*----SetNumbers и зона его ответственности---start---*/
int CountSpaces(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ' ')
            counter++;
    return counter;
}

int[] SetNumbers(string message)
{
    Console.Write(message);
    string input = Console.ReadLine() + " ";
    int[] result = new int[CountSpaces(input)];
    int cursor = 0;
    int digitLen = 0;
    int number = 0;
    int ires = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ' ')
        {
            digitLen = i - cursor;
            number = Convert.ToInt32(input.Substring(cursor, digitLen));
            cursor = i;
            result[ires] = number;
            ires++;
        }
    return result;
}
/*----SetNumbers и зона его ответственности---end---*/

/*----AddNumbers и зона его ответственности---start---*/
int[] AddNumbers(int[] array1)
{
    int[] candidates = SetNumbers("Введите числа, которые вы хотите добавить, через пробел: ");
    int[] result = new int[array1.Length + candidates.Length];
    for (int i = 0; i < array1.Length; i++)
        result[i] = array1[i];
    for (int j = array1.Length; j < array1.Length + candidates.Length; j++)
        result[j] = candidates[j - array1.Length];
    return result;
}
/*----AddNumbers и зона его ответственности---end---*/

/*----RemoveNumbers и зона его ответственности----start--*/
int CountMatches(int[] array1, int num)
{
    int counter = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] == num) counter++;
    }
    return counter;
}

string ArrayToString(int[] array1)
{
    string initialArrayToString = string.Empty;
    for (int i = 0; i < array1.Length; i++)
    {
        initialArrayToString = initialArrayToString + " " + array1[i];
    }
    initialArrayToString = initialArrayToString.Remove(0, 1);
    return initialArrayToString;
}

string NoExcessSpaces(string input)
{
    input = input.Trim(' ');
    for (int i=0; i<input.Length; i++)
        if (input[i]==' ' && input[i+1]==' ')
            input=input.Remove(i,1);
    return input;
}

int[] RemoveNumbers(int[] array1)
{
    int[] candidates = SetNumbers("Введите числа, которые вы хотите убрать, через пробел: ");
    int[] matches = new int[candidates.Length];
    bool zeroMatches = false;
    int sizeDifference = 0;
    for (int i = 0; i < candidates.Length; i++)
    {
        int j = array1.Length - 1;
        matches[i] = CountMatches(array1, candidates[i]);
    }
    if (Sum(matches) == 0) zeroMatches = true;
    if (zeroMatches)
    {
        Console.WriteLine("Совпадений нет.");
        return array1;
    }
    sizeDifference = Sum(matches);
    int[] result = new int[array1.Length - sizeDifference];
    string initialArrayToString = ArrayToString(array1) + " ";
    initialArrayToString = initialArrayToString.Trim(' ');
    initialArrayToString = initialArrayToString + " ";
    string[] initialNumbers = initialArrayToString.Split(' ', array1.Length);
    initialArrayToString = string.Empty;
    for (int i = 0; i < array1.Length; i++)
    {
        for (int j = 0; j < candidates.Length; j++)
            if (initialNumbers[i] == Convert.ToString(candidates[j]))
                initialNumbers[i] = string.Empty;
            initialArrayToString = initialArrayToString + initialNumbers[i]+" ";
    }
    initialArrayToString=NoExcessSpaces(initialArrayToString);
    string[] newNumbers = initialArrayToString.Split(' ', result.Length);
    for (int i = 0; i < result.Length; i++)
        result[i] = Convert.ToInt32(newNumbers[i]);
    return result;

}
/*----RemoveNumbers и зона его ответственности----end--*/

/*----Далее односложные методы------------------------*/
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
    for (int i = 0; i < array1.Length / 2; i++)
    {
        temp = array1[i];
        array1[i] = array1[array1.Length - 1 - i];
        array1[array1.Length - 1 - i] = temp;
    }
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

void SortDecend(int[] array1)
{
    SortAscend(array1);
    Reverse(array1);
}

int Sum(int[] array1)
{
    int result = 0;
    for (int i = 0; i < array1.Length; i++)
        result += array1[i];
    return result;
}

void SumUnevenPos(int[] array1)
{
    int result = 0;
    for (int i = 0; i < array1.Length; i += 2)
        result += array1[i];
    Console.WriteLine($"Сумма всех элементов на нечётных позициях равна: {result}.");
}

void SumEvenPos(int[] array1)
{
    int result = 0;
    for (int i = 1; i < array1.Length; i += 2)
        result += array1[i];
    Console.WriteLine($"Сумма всех элементов на чётных позициях равна: {result}.");
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
        if (array1[i] > max)
        {
            imax = i;
            max = array1[i];
        }
        if (array1[i] < min)
        {
            imin = i;
            min = array1[i];
        }
    }

    Console.WriteLine($"imin={imin}, imax={imax}");
    if (imax == imin + 1 || imin == imax + 1)
        Console.WriteLine("Максимальное и минимальное значения в массиве"
                                                + " находятся рядом друг с другом.");
    else
    {
        result = Math.Abs(imax - imin) - 1;
        Console.WriteLine($"Между максимальным и минимальным значениями "
                                                + $"в массиве {result} элементов.");
    }
}
