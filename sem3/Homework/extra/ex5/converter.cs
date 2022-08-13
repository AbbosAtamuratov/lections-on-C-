// Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
// С помощью команд он может попросить сконвертировать одну валюту в другую. 
// Курс конвертации просто описать в программе. 
// Программа заканчивает свою работу в тот момент, когда решит пользователь.

double ReadDbl(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

string[] currensy = new string[] { "Алтын", "Гульден", "Тугрик" };
// обменный курс 1 алтын = 0,5 гульденов = 10 тугриков
// 1 гульден = 2 алтына = 20 тугриков
// 1 тугрик = 0,1 алтын = 0,05 гульденов

void showMY(double[] array)
{
    Console.WriteLine($"Ваш баланс: {array[0]} ATN -> {array[1]} GDN -> {array[2]} TGK");
}

void Info(string[] currency)
{
    Console.WriteLine("Список команд: ");
    Console.WriteLine("showALL - показывает доступные валюты.");
    Console.WriteLine("showMY - показывает баланс в каждой валюте.");
    Console.WriteLine($"readATN - позволяет ввести сумму в {currency[0]}ах.");
    Console.WriteLine($"readGDN - позволяет ввести сумму в {currency[1]}ах.");
    Console.WriteLine($"readTGK - позволяет ввести сумму в {currency[2]}ах.");
    Console.WriteLine("exit - завершает работу.");
}

double[] ReadATN(double balance)
{
    double[] res = new double[3];
    res[0] = balance;
    res[1] = balance * 0.5;
    res[2] = balance * 10;
    return res;
}

double[] ReadGDN(double balance)
{
    double[] res = new double[3];
    res[0] = balance * 2;
    res[1] = balance;
    res[2] = balance * 20;
    return res;
}

double[] ReadTGK(double balance)
{
    double[] res = new double[3];
    res[0] = balance / 10;
    res[1] = balance * 0.05;
    res[2] = balance;
    return res;
}

void showALL (string[] curr)
{
    Console.WriteLine ("");
    Console.WriteLine ("Вам доступны следующие валюты: ");
    Console.WriteLine ($"{curr[0]}, {curr[1]}, {curr[2]} ");
}

Info(currensy);
double cash = ReadDbl("Введите ваш баланс: ");
double[] converted = ReadTGK (cash);
showALL(currensy);
showMY(converted); 
