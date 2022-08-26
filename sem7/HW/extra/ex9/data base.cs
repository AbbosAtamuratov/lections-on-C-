string[] names = new string[] {"Leo Dzerzhinsky -", "Joseph Lenin -", "Felix Trotsky -", "Vladimir Stalin -"};
string[] occupations = new string[] {" cheif guard -", " creative director -", " icepick boy -"," сheif executive -"};
string[] salaries = new string[] {"35 000","45 000","30 000","55 000"};

string[,] commandList = new string[12, 2]
{
    {"SeeStuff - ", "выводит досье всех сотрудников."}, //1
    {"AddFile - ", "добавяет к уже существующей базе досье."},//2
    {"RemoveFile - ","удаяет досье под номером, введённым пользователем через пробел после имени комнды."},//3
    {"FindByName - ","находит досье по фамилии и выводит его на экран."}, //4
    {"ShowBelow - ","суммирует все элементы массива на чётных позициях."}, //5
    {"ShowAll- ","показывает все досье с указанной должностью."}, //6
    {"Average - ","считает среднее арифметическое всех элементов массива"}, //7
    {"Shuffle - ","перемешивает элементы массива в произвольном порядке"}, //8
    {"Reverse - ","разворачивает массив"}, //9
    {"SortAscend - ", "сортирует массив по возрастанию"}, //10
    {"SortDecend - ", "сортирует массив по убыванию"}, //11
    {"exit - ","завершает работу программы."} //12
};

bool atWork = true;

while (atWork)
{
    Console.WriteLine($"Введите команду или help: ");
    string userCommand = Console.ReadLine();
    switch (userCommand)
    {
        case "help":
            Help(commandList);
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


/*__________METHODS__________*/

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