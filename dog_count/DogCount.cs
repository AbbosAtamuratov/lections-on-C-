// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Два друга вышли навстречу друг другу. У одного из них есть собака.");
Console.WriteLine("Собака бегает от одного друга к другому до тех пор, пока друзья не встретятся");
Console.WriteLine("Первый друг идёт со скоростью в 1 м/с, второй - в 2 м/с, а пёс со скоростью 5 м/с");
Console.WriteLine("Сколько пробежек сделать собака, до тех пор пока друзья не встретятся?");
Console.Write("Введите дистанцию в метрах, с которой начинают друзья: ");
Console.WriteLine(" ");
double dist = Convert.ToDouble(Console.ReadLine());
int v1 = 1;
int v2 = 2;
int vDog = 5;
int buddy = 2;
int count = 0;
double time = 0;
while ( dist>5 ) 
{
    if ( buddy == 1)
    {
        time = dist / (v1+vDog);
        buddy = 1;
    }
    else
    {
        time = dist / (v2+vDog);
        buddy = 2;
    }
    dist = dist - ((v1+v2)*time);
    count++ ;
}
Console.Write("Количество сделанных пробежек: ");
Console.Write(count);