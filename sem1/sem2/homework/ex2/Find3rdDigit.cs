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

char thirdDigit (string word)
{
    int size = word.Length;
    char res = '1';
    int diff = size-3;
    res = Convert.ToChar(word.Substring(word.Length-diff));
    return res;
} 

string input = ReadStr("Введите число: ");
Console.Write(thirdDigit(input));