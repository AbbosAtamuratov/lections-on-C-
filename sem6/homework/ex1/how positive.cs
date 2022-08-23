// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int CountCommas(string input)
{
    int counter = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ',')
            counter++;
    return counter;
}

int[] Numerify(string message)
{
    Console.Write(message);
    string input = Console.ReadLine() + ",";
    int[] result = new int[CountCommas(input)];
    int cursor = 0;
    int digitLen = 0;
    int number = 0;
    string notNumberYet = string.Empty;
    int ires = 0;
    for (int i = 0; i < input.Length; i++)
        if (input[i] == ',')
        {
            digitLen = i - cursor;
            int[] numberByDecimals = new int[digitLen];
            for (int j = cursor; j < digitLen; j++)
            {
                if (input[j]==' ') numberByDecimals[j] = 0;
                else
                {
                notNumberYet = Char.ToString(input[j]);
                numberByDecimals[j] = Convert.ToInt32(notNumberYet);
                }
            }
            for (int k=0; k<digitLen; k++)
            {
                number+=numberByDecimals[k]*Convert.ToInt32(Math.Pow(10, digitLen-k));
            }
            cursor = i;
            result[ires] = number;
            ires++;
        }
    return result;
}

void PrintArray(int[] array1)
{
    Console.Write("Ваш массив: ");
    for (int i = 0; i < array1.Length; i++)
        Console.Write(array1[i] + " ");
    Console.WriteLine("\n");
}
/*------------------------*/
int[] numbers = Numerify("Введите числа через запятую: ");
PrintArray(numbers);
