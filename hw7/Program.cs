// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetFillPrintDoubleArray()
{
Random rand = new Random();
System.Console.Write("Для создания массива введите количество строк(m) и количество столбцов(n).\nСтрок:");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Столбцов:");
int n = Convert.ToInt32(System.Console.ReadLine());
double[,] array2d = new double[m, n];
for(int i = 0; i < array2d.GetLength(0); i++)
{
    for(int j = 0; j < array2d.GetLength(1); j++) 
    {
        array2d[i, j] = rand.Next(-10, 10) + rand.NextDouble();
        System.Console.Write($"{Math.Round(array2d[i,j], 2)}\t");
    }
    System.Console.WriteLine();
}
return array2d;
}

int[,] GetFillPrintIntArray()
{
Random rand = new Random();
System.Console.Write("Для создания массива введите количество строк(m) и количество столбцов(n).\nСтрок:");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Столбцов:");
int n = Convert.ToInt32(System.Console.ReadLine());
int[,] array2d = new int[m, n];
for(int i = 0; i < array2d.GetLength(0); i++)
{
    for(int j = 0; j < array2d.GetLength(1); j++) 
    {
        array2d[i, j] = rand.Next(-10, 10);
        System.Console.Write($"{array2d[i,j]}\t");
    }
    System.Console.WriteLine();
}
return array2d;
}

double[,] myArr = GetFillPrintDoubleArray();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.WriteLine();
double[,] array50 = GetFillPrintDoubleArray();
System.Console.Write($"В массиве {array50.Length} элементов. \nКакой элемент массива Вы хотите увидеть? \nВведите его порядковый номер: ");
int element = Convert.ToInt32(Console.ReadLine());
int countRow = array50.GetLength(0);
int countColumn = array50.GetLength(1);
// System.Console.WriteLine($"строк {countRow} колонок {countCol}");
int indexRow, indexCol;
if(element > array50.Length) System.Console.WriteLine($"{element}-го элемента нет в массиве, их всего {array50.Length}");
else
{
    if (element % countColumn == 0)
    {
        indexRow = (element / countColumn) - 1;
        indexCol = countColumn - 1; 
    }
    else 
    {
        indexRow = element / countColumn;
        indexCol = element % countColumn - 1; 
    }
    System.Console.WriteLine($"{element}-й элемент массива: {Math.Round(array50[indexRow, indexCol], 2)}");
}



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] array52 =  {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};
System.Console.WriteLine();
int[,] array52 = GetFillPrintIntArray();
double[] resArray52 = new double[array52.GetLength(1)];
for(int indColumn = 0; indColumn < array52.GetLength(1); indColumn++)
{
    double sum = 0;
    for (int indRow = 0; indRow < array52.GetLength(0); indRow++)
    {
        sum += array52[indRow, indColumn];
        resArray52[indColumn] = sum / array52.GetLength(0);
    }
}

System.Console.WriteLine("Массив средних арифментических");
for(int i = 0; i < resArray52.Length; i++) System.Console.Write($"{Math.Round(resArray52[i], 2)}\t");