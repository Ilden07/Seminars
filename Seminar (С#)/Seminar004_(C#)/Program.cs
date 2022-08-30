// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int FindSum(int num) 
{
    int sum = 0;

    for (int current = 1; current <= num; current++)
     {
        sum = sum + current;
     }
    return sum;
 }
Console.Write("Input positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ($"Сумма чисел от 1 до {a} равно {FindSum(a)}");
*/

// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int Size(int number)
{
    int size = 0;
    while (number > 0)
     {
        number = number / 10;
        size = size + 1;
     }
    return size;
 }

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sizeNum = Size(num);
Console.Write($"В числе {num} - {sizeNum} цифр.");
*/
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int FindFac(int num)
{
    int fac = 1;

    for (int current = 2; current <= num; current++)
    {
        fac = fac * current;
    }
    return fac;
}

Console.Write("Input positive integer number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Факториал числа {a} равен {FindFac(a)}");
*/
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
/*
int [] MakeArray(int size )
{
    int [] array = new int [size];
    return array ;
}
void FillArray(int[] array)
{
    int lenth = array.Length;
    int i = 0;
    while (i < lenth)
    {
        array[i] = new Random().Next(0, 2);
        i = i + 1;
    }
}
int sizeArr = 8;
int [] array = MakeArray(sizeArr);
FillArray(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
*/
// Этот метод может сгенерировать любой массив
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i< size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

// Метод демонстрирующий массив

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");

    Console.WriteLine();
}
ShowArray(CreateRandomArray(9,0,2));