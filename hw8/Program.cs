// Урок 8. Двумерные массивы. Продолжение
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] arr54 = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3, }, { 8, 4, 2, 4 } };

void Print2Arr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Print2Arr(arr54);
SortArray(arr54);
System.Console.WriteLine();
Print2Arr(arr54);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

System.Console.WriteLine();

int[,] arr561 = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3, }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int[,] arr562 = new int[4, 4] { { 1, 4, 7, 2 }, { 1, 1, 1, 1, }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int[,] arr563 = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 1, 1, }, { 1, 1, 1, 1 }, { 5, 2, 6, 7 } };
int[,] arr564 = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 1, 1, }, { 1, 1, 1, 1 }, { 0, 0, 0, 1 } };

System.Console.WriteLine();
void MinSumLine(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumArray[i] = sum;
    }
    // for(int i = 0; i < sumArray.Length; i++) System.Console.Write($"{sumArray[i]} " );
    int min = 0;
    for (int i = 1; i < sumArray.Length; i++) if (sumArray[i] < sumArray[min]) min = i;
    System.Console.WriteLine($"Минимальная сумма элементов в строке: {min + 1}.");
}
Print2Arr(arr561);
MinSumLine(arr561);
System.Console.WriteLine();
Print2Arr(arr562);
MinSumLine(arr562);
System.Console.WriteLine();
Print2Arr(arr563);
MinSumLine(arr563);
System.Console.WriteLine();
Print2Arr(arr564);
MinSumLine(arr564);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07