string[] names = new string[] { "Leo Dzerzhinsky", "Joseph Lenin", "Felix Trotsky", "Vladimir Stalin" };
string[] occupations = new string[] { "cheif guard", "creative director", "icepick boy", "сheif executive" };
string[] salaries = new string[] { "35 000", "45 000", "30 000", "55 000" };

string[,] commandList = new string[8, 2]
{
    {"SeeCrew - ", "выводит досье всех сотрудников."}, //1
    {"AddFile - ", "добавяет к уже существующей базе досье."},//2
    {"RemoveFile № - ","удаяет досье под номером, дописанным пользователем."},//3
    {"FindByName - ","находит досье по фамилии и выводит его на экран."}, //4
    {"ShowBelow - ","показывает всех сотрудников с ЗП ниже, ."
                                +"введённого пользователем через пробел после имени комнды."}, //5
    {"ShowAll - ","показывает все досье с указанной должностью, " 
                                + " введённой пользователем через пробел после имени комнды."}, //6
    {"AverageRate - ","считает среднюю зарплату всех сотрудников"}, //7
    {"exit - ","завершает работу программы."} //8
};

bool atWork = true;
string currentNames = GlueArray(names);
string currentOccups = GlueArray(occupations);
string currentWagers = GlueArray(salaries);

while (atWork)
{
    Console.WriteLine($"Введите команду или help: ");
    string userCommand = Console.ReadLine();
    switch (userCommand)
    {
        case "help":
            Help(commandList);
            break;
        case "SeeCrew":
            string[] currNames = BackToArray(currentNames);
            string[] currOccups = BackToArray(currentOccups);
            string[] currWagers = BackToArray(currentWagers);
            SeeCrew(currNames, currOccups, currWagers);
            currentNames = GlueArray(currNames);
            currentOccups = GlueArray(currOccups);
            currentWagers = GlueArray(currWagers);
            break;
        case "AddFile":
            Console.Write("Введите фамилию и имя сотрудника: ");
            string inputName = Console.ReadLine();
            Console.Write("Введите должность сотрудника: ");
            string inputOccup = Console.ReadLine();
            Console.Write("Введите зарплату сотрудника: ");
            string inputSalary = Console.ReadLine();
            currentNames = string.Concat(currentNames,"*",inputName);
            currentOccups =string.Concat(currentOccups,"*",inputOccup);
            currentWagers = string.Concat(currentWagers,"*",inputSalary);
            break;
        case "exit":
            atWork = false;
            Console.WriteLine("Всего хорошего...");
            break;
        default:
            Console.WriteLine("Команда не распознана...");
            break;
    }
}


/*________________________METHODS__________________________*/

void Help(string[,] commandList)
{
    Console.WriteLine($"Список комманд:");
    for (int i = 0; i < commandList.GetLength(0); i++)
    {
        for (int j = 0; j < commandList.GetLength(1); j++)
        {
            Console.Write($"{commandList[i, j]}  ");
        }
        Console.WriteLine("");
    }
}

void SeeCrew(string[] name, string[] occup, string[] wager)
{
    for (int i = 0; i < name.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {name[i]} - {occup[i]} - {wager[i]}");
    }
    Console.WriteLine();
}


/*_____________ADD FILES & control zone_______start___________*/

string GlueArray (string[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result = array[i] + "*" + result;    
    }
    return result;
}

string[] BackToArray(string gluedArr)
{
    int size = CountMarkers(gluedArr)+1; 
    string[] result = new string[size]; 
    result = gluedArr.Split('*',size);
    return result;
}

int CountMarkers (string splitable)
{
    int counter = 0;
    for (int i = 0; i < splitable.Length; i++)
    {
        if (splitable[i] == '*')
            counter++;
    }
    return counter;
}

/*_____________ADD FILES & control zone_______end___________*/