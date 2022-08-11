Console.Clear();

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string ReadStr(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string cryForHelp()
{
    Console.Clear();
    Console.WriteLine("Доступные команды: ");
    Console.WriteLine("exit - выход из программы");
    Console.WriteLine("startGG - сыграть угадайку ");
    Console.WriteLine("score - счёт");
    Console.WriteLine("refresh - стереть счёт");
    return ReadStr("Введите команду или help: ");
}

int GetRandomNumber(int a)
{
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

bool runGuessingGame()
{
    bool res = true;
    int firstInput = ReadInt("Введите число, и программа загадает новое число от 0 до вашего: ");
    int randomNumber = GetRandomNumber(firstInput);
    int tries = 2;
    int input = ReadInt("Угадайте число. У вас " + (tries+1) + " попыток: ");
    // проверка Console.WriteLine(randomNumber); 
    while (tries > 0)
    {
        if (tries == 0) 
        {
            break;
        }
        if (input != randomNumber)
        {
            tries--;
            Hint(input, randomNumber);
            input = ReadInt("Угадайте число. У вас " + (tries+1) + " попыток: ");
        }
        else
        {
            break;
        }
    }
    if (tries == 0)
    {
        Console.WriteLine("Не судьба...");
        res = false;
    }
    else
    {
        Console.WriteLine("Красава! Угадал");
    }
    return res;
}


int losses = 0;
int wins = 0;

string input = ReadStr("Введите команду или help: ");

while (input != "exit")
{
    if (input == "help")
    {
        input = cryForHelp();
    }
    else
    {
        {
            switch (input)
            {
                case "startGG":
                    bool result = runGuessingGame();
                    if (result == true)
                    {
                        wins++;
                    }
                    else
                    {
                        losses++;
                    }
                    input = ReadStr("Введите команду: ");
                    break;
                case "score":
                    Console.WriteLine("Компьютер - " + losses + " : " + wins + " - Вы");
                    input = ReadStr("Введите команду: ");
                    break;
                case "refresh":
                    losses = 0;
                    wins = 0;
                    Console.WriteLine("Компьютер - " + losses + " : " + wins + " - Вы");
                    input = ReadStr("Введите команду: ");
                    break;
                case "exit":
                    Console.Write("Завершение работы.");
                    break;
                default:
                    Console.Write("Команда не опознана. ");
                    input = ReadStr("Введите команду: ");
                    break;
            }

        }
    }
}