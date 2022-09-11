// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
int[,] Create2dArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array; 
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
                for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();  
    }

}

Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально допустимое число: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально допустимое число: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = Create2dArray(row, column, minValue, maxValue);
Show2dArray(array);
*/
// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран. (показывает масив, аргументы - строки и столбцы)
/*
int[,] CreateRandom2Array(int строк, int столбцов)
{
 int[,] newArray = новый int[строки, столбцы];
 для (int i = 0; i < строки; i++)
    {
 для (int j = 0; j < столбцы; j ++)
        {
 Новый массив[i,j] = i + j; 
        }
    }
    
 возвращает новый массив;
}
аннулирует ShowArray2(int[,] массив)
{
 для (int i = 0; i < массив.Получить длину (0); i++)
    {
 для (int j = 0; j < массив.Получаем длину (1); j++)
 Консоль.Записать(массив[i,j] + " ");
        
 Консоль.Строка записи();
    }
}
Консоль.Строка записи("Введите количество строк: ");
int m = Преобразовать.ToInt32(консоль.Строка чтения());
Консоль.WriteLine("Ввод количества столбцов: ");
int n = Преобразовать.ToInt32(консоль.Строка чтения());
int[,] newArray = CreateRandom2Array(m, n);
Показать массив2(новый массив);
*/
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты. (массив - массив)

/*
int[,] CreateRandom2Array(int строки, int столбцы, int минимальное значение, int максимальное значение)
{
 int[,] newArray = новый int[строки, столбцы];
 для (int i = 0; i < строки; i++)
    {
 для (int j = 0; j < столбцы; j ++)
        {
 newArray[i,j] = new Random().Next(минимальное значение, максимальное значение + 1); 
        }
    }
    
 возвращает новый массив;
}
аннулирует ShowArray2(int[,] массив)
{
 для (int i = 0; i < массив.Получить длину (0); i++)
    {
 для (int j = 0; j < массив.Получаем длину (1); j++)
 если (i % 2 == 0 && j % 2 == 0)
 массив [i,j] = Math.Pow(массив[i,j], 2);
 Консоль.Записать(массив[i,j] + " ");
        
 Консоль.Строка записи();
    }
}
Консоль.Строка записи("Введите количество строк: ");
int m = Преобразовать.ToInt32(консоль.Строка чтения());
Консоль.Строка записи("Введите количество столбцов: ");
int n = Преобразовать.ToInt32(консоль.Строка чтения());
Консоль.Строка записи("Введите минимально возможное значение: ");
int min = Преобразовать.ToInt32(консоль.Строка чтения());
Консоль.WriteLine("Введите максимально возможное значение: ");
int max = Преобразовать.ToInt32(консоль.Строка чтения());
int[,] newArray = CreateRandom2Array(m, n, min, max);
ShowArray2(Новый массив);
*/

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] Create2dArray(int row, int column)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
            array[i, j] = i + j;
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стоблцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2dArray(row, column);
Show2dArray(array);
*/
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
int[,] CreateRandom2dArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i ++)
        for(int j = 0; j < column; j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write("  ");
        }
        Console.WriteLine();
    }
}

void QuadEvenIndex(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i += 2)
        for(int j = 0; j < array.GetLength(1); j += 2)
            array[i, j] *= array[i, j];
}

Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально допустимое число: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально допустимое число: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(row, column, minValue, maxValue);
Show2dArray(array);
Console.WriteLine();
QuadEvenIndex(array);
Show2dArray(array);
*/



// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
int[,] CreateRandom2dArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    for(int i = 0; i < row; i++)
        for(int j = 0; j < column; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int SumDiagValue(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
        sum += array[i, i];
    return sum;
}

Console.Write("Введите количество строк в массиве: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально допустимое число: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально допустимое число: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = CreateRandom2dArray(row, column, minValue, maxValue);
Show2dArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов по главной диагонали равна {SumDiagValue(array)}");
*/