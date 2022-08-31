//Задача №25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int DegreeOfNum(int numberA, int numberB)
{
    int i = numberA;
    for (int current = 1; current < numberB; current ++)
        i = i * numberA;
    
    return i;
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the degree of the number: ");
int deg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DegreeOfNum(num, deg));
*/
//Задача №27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumOfDigits(int number)
{
    int current = number;
    int digits = 0;
    int sum = 0;
    while (current > 0)
    {
        sum = (current % 10) + sum;
        current = current / 10;
        digits = digits + 1;
    }
    return sum;
}
Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(num));
*/
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} array element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void ShowArray (int [] array)
{
    Console.Write("The resulting array: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
        
}

Console.Write("Enter the size: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(sizeArr);
ShowArray(array);
