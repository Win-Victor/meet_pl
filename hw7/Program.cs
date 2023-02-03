// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetFillPrintArray()
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

double[,] myArr = GetFillPrintArray();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

double[,] array50 = GetFillPrintArray();






// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

