// Задача № 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
/*
Console.Write("Enter a five-digit number: ");
string? number = Console.ReadLine();
void CheckingNumber(string number)
{
 if (number[0]==number[4] || number[1]==number[3])
 {
 Console.WriteLine($"This number {number} is a palindrome");
  }
 else Console.WriteLine($"This number {number} is not a palindrome");
}

if (number!.Length == 5)
{
 CheckingNumber(number);
}
else Console.WriteLine($"The number does not match the condition");
*/
// Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double xi = xA - xB;
    double yi = yA - yB;
    double zi = zA - zB;
    double dist = Math.Sqrt(xi * xi + yi * yi + zi * zi);
    return dist;
}
Console.Write("Input xA coordinate, 1 point: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA coordinate, 1 point: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zA coordinate, 1 point: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB coordinate, 2 point: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB coordinate, 2 point: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zB coordinate, 2 point: ");
double zB = Convert.ToDouble(Console.ReadLine());
double distance = Distance(xA, yA, zA, xB, yB, zB);
Console.Write("The distance between the points is equal to " + distance);
*/
// Задача №23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int num)
{
    int current = 1;
    while(current <= num)
    {
        Console.WriteLine($"The cube of the number {current} is equal to {Math.Pow(current, 3)}");
        current = current + 1;
    }
}
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);
*/
