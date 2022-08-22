// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int number = ReadInt("Введите число: ");

if(number == 1 || number == 2)
{
    Console.Write("Для ряда Фибоначчи нужно число больше 2 ");
    return;
}

int[] fibonacci = new int[number];
fibonacci[0] = 0;
fibonacci[1] = 1;

for (int i = 2; i < number; i++)
{
    fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];  
}
