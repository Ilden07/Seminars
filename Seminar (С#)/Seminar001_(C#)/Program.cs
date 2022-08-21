
/* Задача №1. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int kvadrat = number * number;

Console.WriteLine("The quad of " + number + " is " + kvadrat);

Console.WriteLine($"The quad of {number} is {kvadrat}");
*/

/*Задача №2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int kvadrat = number2 * number2;
if(number1 == kvadrat)
{
    Console.Write("The first number is the square of the second");
}
else
{
    Console.Write("The first number is not the square of the second");
}*/

/*Задача №3. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.*/

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = number * (-1);
while (current <= number)
{
    Console.Write(current + " ");

    current = current + 1;

}