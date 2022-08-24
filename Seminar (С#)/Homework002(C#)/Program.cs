/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
int SecondDigit(int number)
{
    int Secondnumber = number % 100;
    int result = Secondnumber / 10;

    return result; 
}   
int num;
Console.WriteLine("Input number   : ");
num = Convert.ToInt32(Console.ReadLine());
int completeNumber = SecondDigit(num);

Console.WriteLine($"The second digit of the  number {num} is {completeNumber}");
*/
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
/*
void ThirdNumber(int number)
{
    if(number > 99)
    {
        int len = number.ToString().Length;
        int a = Convert.ToInt32(Math.Pow(10, len - 2));
        int b = Convert.ToInt32(Math.Pow(10, len - 3));
        int corNum = number % a;
        int oneNum = corNum / b;
        Console.WriteLine($"The third digit of the number: {number} is {oneNum}.");
    }
    else
    {
        Console.WriteLine($"The number: {number} has no third digit.");
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdNumber(num);
*/

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) //  || - Логическое "ИЛИ" (6 или 7)
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
 
  else Console.WriteLine("(этот день не выходной) -> нет");
}

Console.Write("Введи цифру, обозначающую день недели: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

CheckingTheDayOfTheWeek(dayNumber);

