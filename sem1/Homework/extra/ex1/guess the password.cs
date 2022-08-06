/*В переменной string есть секретное сообщение, 
во второй есть пароль. Пользователю программы 
даётся 3 попытки ввести пароль и увидеть 
секретное сообщение.*/

string SecretMsg = "Красавец! Ты угадал пароль!";
int count = 3;
string input = "1";
string password = "coockie";
Console.WriteLine("У вас есть " + count + " попытки." + " Введите пароль: ");
while (count>0)
{
    input = Console.ReadLine();
    if (input == password)
    {
        Console.WriteLine(SecretMsg);
        break;
    }
    else
    {
        Console.WriteLine("Хорошая попытка, но нет...");
    }
    count--;
    if (count == 1)
    {
        Console.WriteLine("У вас осталось " + count + " попытка. Попробуйте ещё раз.");
    }
    else
    {
        Console.WriteLine("У вас осталось " + count + " попытки. Попробуйте ещё раз.");
    }
}
if (count == 0)
{
    Console.WriteLine("Не судьба...");
}