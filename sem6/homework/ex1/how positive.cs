// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int CountCommas(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ',')
            counter++;
    return counter;
}

int CountMinuses(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == '-')
            counter++;
    return counter;
}

int CountZeros(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == '0' && input[i-1] == ' ' && input[i+1] == ',')
            counter++;
    return counter;
}

/*--------MAIN-----------*/
Console.Write("Введите цифры через запятую: ");
string userInput = Console.ReadLine() + ",";
int zeros = CountZeros(userInput);
userInput = userInput.Replace(" ", "");
int numbersCount= CountCommas(userInput);
if (userInput.Length==numbersCount)
    {
        Console.Write ("Цифр не обнаружено...");
        return;
    }
int minuses = CountMinuses(userInput);
Console.WriteLine (numbersCount-zeros-minuses);