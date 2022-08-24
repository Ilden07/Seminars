/* Задача №1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа/

int FindBiggerGigit(int number)

{
    int ed = number % 10;
    int dec = number / 10;
    
    int max;
    if (ed > dec) max = ed;
    else max = dec;

    return max;
}

int randNumber = new Random().Next(10, 100);
int biggerDigit = FindBiggerGigit(randNumber);

Console.WriteLine($"Bigger diget of {randNumber} is {biggerDigit}");
*/

/* Задача №2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int SecondDigit(int number)
{
    int firstNumber = number / 100;
    int thirdNumber = number % 10;
    int result = firstNumber * 10 + thirdNumber;

    return result; 
}   
int randNumber = new Random().Next(100,1000);
int completeNumber = SecondDigit(randNumber);

Console.WriteLine($"A number without the second digit of the number {randNumber} is {completeNumber}");
*/

/* Задача №3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
   Если второе число не кратно числу первому, то программа выводит остаток от деления.
  
   void Message(int num1, int num2)
{
    int ost = num2 % num1;
    if (ost == 0)
    {
        Console.WriteLine($"Число {num2} кратно числу {num1}");
    }
    else
    {
        Console.WriteLine($"Остаток от деления {ost}");
    }
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Message(number1, number2);
*/