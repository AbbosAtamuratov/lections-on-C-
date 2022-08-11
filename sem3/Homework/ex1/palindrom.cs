// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/* 14212 -> нет
   12821 -> да*/

string ReadStr (string UImsg)
{
   Console.Write (UImsg);
   return Console.ReadLine();
}

bool Palindrome5DCheck (string input)
{
   return input[0] == input[4] && input[1] == input[3];
}

bool isIt5D (string input)
{
   if (input.Length == 5)
   {
      return true;
   }
   else
   { 
      return false;
   }
}

string message = ReadStr("Введите пятизначное число: ");
while (!isIt5D(message))
{
   message = ReadStr("Введите ПЯТИЗНАЧНОЕ число: ");
}

if (!Palindrome5DCheck(message))
{
   Console.Write ($"{message} -> нет");
}
else
{
   Console.Write ($"{message} -> да");
}
