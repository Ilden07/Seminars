//Задача №41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2

/*
int PositiveNum(int m)
{
 int current = 0;
 for (int x = 1; x <= m; x++)
    {
        Console.Write($"Введите число №{x}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) current++;
    }
 return current;
}
Console.Write("Введите количество числе: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = PositiveNum(num);

Console.WriteLine($"Из {num} введённых чисел было:  {result} положительных!");
*/

/* Задача №43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 
 */
/*
void Intersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (k1==k2 && b1 == b2) Console.WriteLine("Первая прямая совпадает со второй!");
    else if (k1 == k2) Console.WriteLine("Данные прямые не пересекаются! Они параллельны!");
    else Console.WriteLine($"Данные прямые пересекутся в [{x},{y}]!");
}

Console.WriteLine("Первая прямая: y = k1 * x + b1");
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая прямая: y = k2 * x + b2");
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Intersection(k1, b1, k2, b2);
*/
