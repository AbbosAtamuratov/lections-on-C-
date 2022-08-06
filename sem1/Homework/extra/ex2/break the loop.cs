Console.Clear();
Console.WriteLine("Напиши ВЫХОД по-английски: ");
string input = "googoo gaga";
while (input != "exit")
{
    input = Console.ReadLine();
    if (input == "exit")
    {
        break;
    }
    else
    {    
        Console.WriteLine("Неправильно!");
    }
}
