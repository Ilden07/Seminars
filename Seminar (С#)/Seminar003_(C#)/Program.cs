/*Задача №1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер четверти плоскости, в которой находится эта точка.*/
/*
int FindQuarant(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
Console.Write("Input x coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuarant(xA, yA);
Console.WriteLine("Num of quad is " + quadrant);
*/
/*Задача №2. Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/
/*
void FindInterval(int num)
{
    if(num == 1) Console.WriteLine($"Диапазон возможных координат в четверти {num}: x > 0, y > 0 ");
    if(num == 2) Console.WriteLine($"Диапазон возможных координат в четверти {num}: x < 0, y > 0 ");
    if(num == 3) Console.WriteLine($"Диапазон возможных координат в четверти {num}: x < 0, y < 0 ");
    if(num == 4) Console.WriteLine($"Диапазон возможных координат в четверти {num}: x > 0, y < 0 ");
    if(num < 0 || num > 4) Console.WriteLine($"Такой четверти не существует");
}
Console.WriteLine("Введите номер четверти: ");
int quad = Convert.ToInt32(Console.ReadLine());
FindInterval(quad);
*/
/*Задача №3. Напишите программу, которая принимает на вход число (n) и выдаёт квадраты чисел от 1 до n.*/
/*
void Quad(int n)
{
    int i = 1;
    while (i <= n)
    {
        if (i == n) Console.Write($"{i * i}, ");
        else Console.Write($"{i * i}, ");
        i++;
    }
}
Console.Write("Введите натральное число: ");
int number = Convert.ToInt32 (Console.ReadLine());
Quad(number);
*/
/*Задача №4. 3. Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.*/
double FindDistance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
}
Console.WriteLine("Enter xA dot ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter yA dot ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter xB dot ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter yB dot ");
double yB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance(xA , yA, xB, yB);
Console.WriteLine($"dist is {dist} ");