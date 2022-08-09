// Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, 
// то программа сообщает, больше загаданное число или меньше. На отгадывание дается 3 попытки.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomNumber(int a)
{
    a = ReadInt("Введите число, и программа загадает новое число от 0 до вашего: ");
    int res = new Random().Next(0, a);
    return res;
}

void Hint(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine("Не совсем. Меньше..");
    }
    else
    {
        Console.WriteLine("Не совсем. Больше..");
    }
}

int firstInput = 0;
int randomNumber = GetRandomNumber(firstInput);
int tries = 3;
int input = ReadInt("Угадайте число. У вас " + tries + " попыток: ");
// проверка Console.WriteLine(randomNumber); 
while (tries > 0)
{
    if (input != randomNumber)
    {
        tries--;
        Hint(input, randomNumber);
        input = ReadInt("Угадайте число. У вас " + tries + " попыток: ");
    }
    else
    {
        break;
    }
}
if (tries == 0)
{
    Console.WriteLine("Не судьба...");
}
else
{
    Console.WriteLine("Красава! Угадал");
}