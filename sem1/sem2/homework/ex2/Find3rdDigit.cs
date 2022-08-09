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

int niceTrim(string word, int a)
{
    int size = word.Length;
    int res = Convert.ToInt32(word);
    while (size > a)
    {
        res /= 10;
        size--;
    }
    return res;
}
string input = ReadStr("Введите число больше 99: ");
if(isItBigEnough(input) == true)
{
    Console.Write("Третья цифра: " + niceTrim(input, 3) % 10);
}
else
{
    Console.Write("Третьей цифры нет!");
}