// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
string ReadStr(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

bool isItBigEnough(string a)
{
    return a.Length > 2;
}

int[] Reverse(int[] a)
{
    int size = a.Length;
    int i = 0;
    int tmp = 0;
    while (i < size / 2)
    {
        tmp = a[i];
        a[i] = a[size - 1 - i];
        a[size - i - 1] = tmp;
        i++;
    }
    return a;
}

int[] Decompose(string word)
{
    int size = word.Length;
    int wordToNumber = Convert.ToInt32(word);
    int[] a = new int[size];
    int i = 0;
    while (i < size)
    {
        a[i] = wordToNumber % 10;
        wordToNumber /= 10;
        i++;
    }
    return Reverse(a);
}


string input = ReadStr("Введите число больше 99: ");
int[] array = Decompose(input);
if (isItBigEnough(input) == true)
{
    Console.Write("Третья цифра: " + array[2]);
}
else
{
    Console.Write("Третьей цифры нет!");
}
