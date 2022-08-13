// Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
// С помощью команд он может попросить сконвертировать одну валюту в другую. 
// Курс конвертации просто описать в программе. 
// Программа заканчивает свою работу в тот момент, когда решит пользователь.

double ReadDbl(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}

string ReadStr (string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string[] currensy = new string[] { "Алтын", "Гульден", "Тугрик" }; // валюты
string[] CRR = new string[] {"ATN", "GDN", "TGK"}; //сокращённые названия
// обменный курс 1 алтын = 0,5 гульденов = 10 тугриков
// 1 гульден = 2 алтына = 20 тугриков
// 1 тугрик = 0,1 алтын = 0,05 гульденов

void showMY(double[] array)
{
    Console.WriteLine ("");
    Console.WriteLine($"Ваш баланс: {array[0]} ATN это {array[1]} GDN или {array[2]} TGK");
}

void Info(string[] currency)
{
    Console.WriteLine ("");
    Console.WriteLine("Список команд: ");
    Console.WriteLine("showALL - показывает доступные валюты.");
    Console.WriteLine("showMY - показывает баланс в каждой валюте.");
    Console.WriteLine($"readATN - позволяет ввести сумму в {currency[0]}ах.");
    Console.WriteLine($"readGDN - позволяет ввести сумму в {currency[1]}ах.");
    Console.WriteLine($"readTGK - позволяет ввести сумму в {currency[2]}ах.");
    Console.WriteLine ($"ATNtoGDN- переводит вашу сумму из {currency[0]}ов в {currency[1]}ы.");
    Console.WriteLine ($"ATNtoTGK - переводит ваш сумму из {currency[0]}ов в {currency[2]}и.");
    Console.WriteLine ($"GDNtoATN - переводит ваш сумму из {currency[1]}ов в {currency[0]}ы.");
    Console.WriteLine ($"GDNtoTGK - переводит ваш сумму из {currency[1]}ов в {currency[2]}и.");
    Console.WriteLine ($"TGKtoATN - переводит ваш сумму из {currency[2]}ов в {currency[0]}ы.");
    Console.WriteLine ($"TGKtoGDN - переводит ваш сумму из {currency[2]}ов в {currency[1]}ы.");
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

void ATNtoGDN (string[] curr, double[] ballance)
{
    Console.WriteLine ("");
    Console.WriteLine ($"{ballance[0]} {curr[0]} -> {ballance[1]} {curr[1]}");
    Console.WriteLine ("");

}

void ATNtoTGK (string[] curr, double[] ballance)
{
    Console.WriteLine ("");
    Console.WriteLine ($"{ballance[0]} {curr[0]} -> {ballance[2]} {curr[2]}");
    Console.WriteLine ("");

}

void GDNtoATN (string[] curr, double[] ballance)
{
    Console.WriteLine ("");
    Console.WriteLine ($"{ballance[1]} {curr[1]} -> {ballance[0]} {curr[0]}");
    Console.WriteLine ("");

}

void GDNtoTGK (string[] curr, double[] ballance)
{
    Console.WriteLine ("");
    Console.WriteLine ($"{ballance[1]} {curr[1]} -> {ballance[2]} {curr[2]}");
    Console.WriteLine ("");

}

void TGKtoATN (string[] curr, double[] ballance)
{
    Console.WriteLine ("");
    Console.WriteLine ($"{ballance[2]} {curr[2]} -> {ballance[0]} {curr[0]}");
    Console.WriteLine ("");

}

void TGKtoGDN (string[] curr, double[] ballance)
{
    Console.WriteLine ("");
    Console.WriteLine ($"{ballance[2]} {curr[2]} -> {ballance[1]} {curr[1]}");
    Console.WriteLine ("");

}

Console.Clear();
/* проверка и отладка команд
Info(currensy);
showALL(currensy);
double cash = ReadDbl("Введите ваш баланс: ");
double[] converted = ReadTGK (cash);
showMY(converted); 
ATNtoGDN(CRR, converted);
ATNtoTGK(CRR, converted);
GDNtoATN(CRR, converted);
GDNtoTGK(CRR, converted);
TGKtoATN(CRR, converted);
TGKtoGDN(CRR, converted);
*/
bool atWork = true;
string input = "";
double[] myMoney = ReadATN(0); 
while (atWork)
{
    input = ReadStr("Введите команду или info: ");
    switch (input)
    {
        case "info":
            Info(currensy);
            break;
        case "showALL":
            showALL(currensy);
            break;
        case "showMY":
            showMY(myMoney);
            break;
        case "readATN":
            myMoney = ReadATN(ReadDbl($"Веведите сумму в {currensy[0]}ах: "));
            break;
        case "readGDN":
            myMoney = ReadGDN(ReadDbl($"Веведите сумму в {currensy[1]}ах: "));
            break;
        case "readTGK":
            myMoney = ReadTGK(ReadDbl($"Веведите сумму в {currensy[2]}ах: "));
            break;
        case "ATNtoGDN":
            ATNtoGDN(CRR, myMoney);
            break;
        case "ATNtoTGK":
            ATNtoTGK(CRR, myMoney);
            break;
        case "GDNtoATN":
            GDNtoATN(CRR, myMoney);
            break;
        case "GDNtoTGK":
            GDNtoTGK(CRR, myMoney);
            break;
        case "TGKtoATN":
            TGKtoATN(CRR, myMoney);
            break;
        case "TGKtoGDN":
            TGKtoGDN(CRR, myMoney);
            break;
        case "exit":
            atWork = false;
            break;
        default:
            Console.WriteLine("Некорректный ввод");
            break;
    }
}