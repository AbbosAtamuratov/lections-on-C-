string[] names = new string[] { "Jonathan Joestar", "Joseph Joestar", "Jotaro Kujo", "Josuke Higashikata", "Giorno Jiovanni" };
string[] occupations = new string[] { "founder", "OG", "cheif security", "PR manager", "HR manager" };
string[] salaries = new string[] { "100 000", "85 000", "75 000", "55 000", "60 000" };

string[,] commandList = new string[10, 2]
{
    {"SeeCrew - ", "выводит досье всех сотрудников."}, //1
    {"AddFile - ", "добавяет к уже существующей базе досье."},//2
    {"RemoveFile - ","удаяет досье под номером, введённым пользователем."},//3
    {"FindByName - ","находит первое досье по фамилии и выводит его на экран."}, //4
    {"ShowBelow - ","показывает всех сотрудников с ЗП ниже введённого пользователем."}, //5
    {"ShowAll - ","показывает все досье с указанной должностью, "
                                + " введённым пользователем."}, //6
    {"AverageRate - ","считает среднюю зарплату всех сотрудников"}, //7
    {"ShowFile# - ","показывает досье под определённым номером."}, // 8
    {"FindNamesakes - ","находит однофамильцев и выводит на экран их досье."}, //9
    {"exit - ","завершает работу программы."} //10
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
            string inputName = ReadString("Введите фамилию и имя сотрудника: ");
            string inputOccup = ReadString("Введите должность сотрудника: ");
            string inputSalary = ReadString("Введите зарплату сотрудника: ");
            currentNames = string.Concat(currentNames, "*", inputName);
            currentOccups = string.Concat(currentOccups, "*", inputOccup);
            currentWagers = string.Concat(currentWagers, "*", inputSalary);
            break;
        case "RemoveFile":
            int target = ReadInt("Введите номер досье: ");
            string[] tmpNames = BackToArray(currentNames);
            string[] tmpOccups = BackToArray(currentOccups);
            string[] tmpWagers = BackToArray(currentWagers);
            string[] tempNames = RemoveTarget(tmpNames, target);
            string[] tempOccups = RemoveTarget(tmpOccups, target);
            string[] tempWagers = RemoveTarget(tmpWagers, target);
            currentNames = GlueArray(tempNames);
            currentOccups = GlueArray(tempOccups);
            currentWagers = GlueArray(tempWagers);
            Console.WriteLine("готово...");
            break;
        case "FindByName":
            string[] tempoNames = BackToArray(currentNames);
            string[] tempoOccups = BackToArray(currentOccups);
            string[] tempoWagers = BackToArray(currentWagers);
            string targetName = ReadString("Введите фамилию: ");
            int targetI = FindByName(tempoNames, targetName);
            if (targetI == -1)
                Console.WriteLine("Сотрудник не найден");
            else
                Console.WriteLine($"{targetI + 1}. {tempoNames[targetI]} - {tempoOccups[targetI]} - {tempoWagers[targetI]}");
            currentNames = GlueArray(tempoNames);
            currentOccups = GlueArray(tempoOccups);
            currentWagers = GlueArray(tempoWagers);
            break;
        case "ShowFile#":
            string[] temporNames = BackToArray(currentNames);
            string[] temporOccups = BackToArray(currentOccups);
            string[] temporWagers = BackToArray(currentWagers);
            int targetN = ReadInt("Введите номер досье: ");
            if (targetN - 1 > currentNames.Length)
                Console.WriteLine("Досье с таким номером нет!");
            else
            {
                ShowFileN(temporNames, temporOccups, temporWagers, targetN);
                currentNames = GlueArray(temporNames);
                currentOccups = GlueArray(temporOccups);
                currentWagers = GlueArray(temporWagers);
            }
            break;
        case "ShowBelow":
            int inputAmount = ReadInt("Введите сумму: ");
            string[] zahlen = BackToArray(currentNames);
            string[] besetzung = BackToArray(currentOccups);
            string[] gehalt = BackToArray(currentWagers);
            Console.WriteLine("Сотрудники с зарплатой ниже введённой: ");
            int[] belows = FindBelow(gehalt, inputAmount);
            if (belows[0] == -1)
                Console.WriteLine("Совпадений нет...");
            else
                ShowTargets(zahlen, besetzung, gehalt, belows);
            currentNames = GlueArray(zahlen);
            currentOccups = GlueArray(besetzung);
            currentWagers = GlueArray(gehalt);
            break;
        case "AverageRate":
            string[] numeros = BackToArray(currentWagers);
            Console.WriteLine($"Средняя зароботная плата всех {numeros.Length} сотрудников:\n {AverageRate(numeros)}");
            currentWagers = GlueArray(numeros);
            break;
        case "ShowNamesakes":
            string inputSurname = ReadString("Введите Фамилию: ");
            string[] isimlar = BackToArray(currentNames);
            string[] ishlar = BackToArray(currentOccups);
            string[] pullari = BackToArray(currentWagers);
            Console.WriteLine($"Однофамильцы {inputSurname}: ");
            int[] namesakes = FindNamesakes(isimlar, inputSurname);
            if (namesakes[0] == -1)
                Console.WriteLine("Совпадений нет...");
            else
                ShowTargets(isimlar, ishlar, pullari, namesakes);
            currentNames = GlueArray(isimlar);
            currentOccups = GlueArray(ishlar);
            currentWagers = GlueArray(pullari);
            break;
        case "ShowAll":
            string inputJob = ReadString("Введите должность: ");
            string[] ileum = BackToArray(currentNames);
            string[] ilgwa = BackToArray(currentOccups);
            string[] don = BackToArray(currentWagers);
            if (!AreThereJobbers(ilgwa, inputJob))
                Console.WriteLine($"Должности {inputJob} не обнаружено");
            else
            {
                int[] list = ShowAll(ilgwa, inputJob);
                Console.WriteLine($"Все {inputJob}: ");
                ShowTargets(ileum, ilgwa, don, list);
            }
            currentNames = GlueArray(ileum);
            currentOccups = GlueArray(ilgwa);
            currentWagers = GlueArray(don);
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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

/*_____________ADD FILES & control zone_______start___________*/

string GlueArray(string[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != string.Empty)
            result = result + "*" + array[i];
    }
    result = result.Remove(0, 1);
    return result;
}

string[] BackToArray(string gluedArr)
{
    int size = CountMarkers(gluedArr) + 1;
    string[] result = new string[size];
    result = gluedArr.Split('*', size);
    return result;
}

int CountMarkers(string splitable)
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

/*------------------------ShowBelow control zone-----start---*/

int[] FindBelow(string[] wagers, int target)
{
    int counter = 0;
    int[] result = new int[wagers.Length];
    int order = 0;
    for (int i = 0; i < wagers.Length; i++)
        if (Convert.ToInt32(wagers[i].Replace(" ", "")) < target)
        {
            counter++;
            result[order] = i + 1;
            order++;
        }
    return result;
}

int CountNonZeros(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] != 0)
            counter++;
    return counter;
}

void ShowTargets(string[] names, string[] occups, string[] wagers, int[] targets)
{
    for (int i = 0; i < CountNonZeros(targets); i++)
        ShowFileN(names, occups, wagers, targets[i]);
}

/*------------------------ShowBelow control zone-----end-----*/

/*------------------------ShowAll control zone---start-----*/

bool AreThereJobbers(string[] jobList, string target)
{
    for (int i = 0; i < jobList.Length; i++)
        if (jobList[i] == target)
            return true;
    return false;
}

int[] ShowAll(string[] jobList, string target)
{
    int counter = 0;
    int[] result = new int[jobList.Length];
    int order = 0;
    for (int i = 0; i < jobList.Length; i++)
        if (jobList[i] == target)
        {
            counter++;
            result[order] = i + 1;
            order++;
        }
    if (counter == 0)
        result[0] = -1;
    return result;
}

/*------------------------ShowAll control zone-----end-----*/

/*------------------------FindNamesakes control zone-----start---*/

int[] FindNamesakes(string[] names, string target)
{
    int counter = 0;
    int[] result = new int[names.Length];
    int order = 0;
    for (int i = 0; i < names.Length; i++)
        if (names[i].Substring(names[i].IndexOf(' ') + 1, names[i].Length - names[i].IndexOf(' ') - 1) == target)
        {
            counter++;
            result[order] = i + 1;
            order++;
        }
    if (counter == 0)
        result[0] = -1;
    return result;
}

/*------------------------FindNamesakes control zone-----end-----*/

/*__________________односложные методы__________________________*/

string[] RemoveTarget(string[] array, int target)
{
    string[] result = new string[array.Length - 1];
    for (int i = 0; i < target; i++)
        result[i] = array[i];
    for (int i = target - 1; i < result.Length; i++)
        result[i] = array[i + 1];
    return result;
}

int FindByName(string[] array, string name)
{
    int targetIndex = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Substring(array[i].IndexOf(' ') + 1, array[i].Length - array[i].IndexOf(' ') - 1) == name)
        {
            targetIndex = i;
            break;
        }
    }
    return targetIndex;
}

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

void ShowFileN(string[] a, string[] b, string[] c, int number)
{
    Console.WriteLine($"{number}. {a[number - 1]} - {b[number - 1]} - {c[number - 1]}");
}

double AverageRate(string[] wagers)
{
    int sum = 0;
    for (int i = 0; i < wagers.Length; i++)
        sum += Convert.ToInt32(wagers[i].Replace(" ", ""));
    return Math.Round(Convert.ToDouble(sum) / wagers.Length, 2);
}