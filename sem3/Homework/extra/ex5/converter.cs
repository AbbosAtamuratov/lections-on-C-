// Конвертер валют. У пользователя есть баланс в каждой из представленных валют. 
// С помощью команд он может попросить сконвертировать одну валюту в другую. 
// Курс конвертации просто описать в программе. 
// Программа заканчивает свою работу в тот момент, когда решит пользователь.

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string[] currensy = new string[] { "Алтын", "Гульден", "Тугрик" };
// обменный курс 1 алтын = 0,5 гульденов = 10 тугриков
// 1 гульден = 2 алтына = 20 тугриков
// 1 тугрик = 0,1 алтын = 0,05 гульденов

string printConvertationDirection(string a, string b)
{
    return a + " -> " + b;
}

void Info (string[] currency)
{
    Console.WriteLine ("Список команд: ");
    Console.WriteLine ("showALL - показывает доступные валюты.");
    Console.WriteLine ("showMY - показывает баланс в текущей валюте.");
    Console.WriteLine ($"read_ATN - позволяет ввести сумму в {currency[0]}ах.");
    Console.WriteLine ($"read_GDN - позволяет ввести сумму в {currency[1]}ах.");
    Console.WriteLine ($"read_TGK - позволяет ввести сумму в {currency[2]}ах.");
    Console.WriteLine ($"ATNtoGDN- переводит ваш баланс из {currency[0]}ов в {currency[1]}ы.");
    Console.WriteLine ($"ATNtoTGK - переводит ваш баланс из {currency[0]}ов в {currency[2]}и.");
    Console.WriteLine ($"GDNtoATN - переводит ваш баланс из {currency[1]}ов в {currency[0]}ы.");
    Console.WriteLine ($"GDNtoTGK - переводит ваш баланс из {currency[1]}ов в {currency[2]}и.");
    Console.WriteLine ($"TGKtoATN - переводит ваш баланс из {currency[2]}ов в {currency[0]}ы.");
    Console.WriteLine ($"TGKtoGDN - переводит ваш баланс из {currency[2]}ов в {currency[1]}ы.");
    Console.WriteLine ("exit - завершает работу.");
}

Info(currensy);