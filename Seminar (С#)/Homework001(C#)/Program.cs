/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
int a, b;

Console.WriteLine("Input number a  : ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number b  : ");
b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.Write("Max = {0} ", a);
}
else
{
    Console.Write("MAX = {0} ", b);
}
Console.ReadLine();
*/
/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
int a, b, c;

Console.WriteLine("Input number a  : ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number b  : ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number c  : ");
c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max); */

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.WriteLine("Input number : ");
int number;
number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.Write("Yes, the number is even");
}
else
{
    Console.Write("No, the number is odd");
}
*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Input number : ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
Console.WriteLine("an even number from 1 to " + number);
while (current <= number)

{
    if  (current % 2 != 1)
    {
    Console.Write ($"{current},  ");
    }
    current = current + 1;
}