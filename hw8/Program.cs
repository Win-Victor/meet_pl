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
            System.Console.Write($"{arr[i, j]}\t");
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

// Print2Arr(arr54);
// SortArray(arr54);
// System.Console.WriteLine();
// Print2Arr(arr54);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// System.Console.WriteLine();

int[,] arr561 = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3, }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int[,] arr562 = new int[4, 4] { { 1, 4, 7, 2 }, { 1, 1, 1, 1, }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
int[,] arr563 = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 1, 1, }, { 1, 1, 1, 1 }, { 5, 2, 6, 7 } };
int[,] arr564 = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 1, 1, }, { 1, 1, 1, 1 }, { 0, 0, 0, 1 } };

// System.Console.WriteLine();
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
// Print2Arr(arr561);
// MinSumLine(arr561);
// System.Console.WriteLine();
// Print2Arr(arr562);
// MinSumLine(arr562);
// System.Console.WriteLine();
// Print2Arr(arr563);
// MinSumLine(arr563);
// System.Console.WriteLine();
// Print2Arr(arr564);
// MinSumLine(arr564);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = new int[2, 2] { { 2, 4 }, { 3, 2 } };
int[,] array2 = new int[2, 2] { { 3, 4 }, { 3, 3 } };

void MultArray(int[,] arr1, int[,] arr2)
// работает только для умножения 2 матриц 2 х 2.
{
    int[,] multArray = new int[2, 2];
    multArray[0, 0] = array1[0, 0] * array2[0, 0] + array1[0, 1] * array2[1, 0];
    multArray[0, 1] = array1[0, 0] * array2[0, 1] + array1[0, 1] * array2[1, 1];
    multArray[1, 0] = array1[1, 0] * array2[0, 0] + array1[1, 1] * array2[1, 0];
    multArray[1, 1] = array1[1, 0] * array2[0, 1] + array1[1, 1] * array2[1, 1];
    System.Console.WriteLine();
    Print2Arr(arr1);
    System.Console.WriteLine("Умножить на");
    Print2Arr(arr2);
    System.Console.WriteLine("Равно");
    Print2Arr(multArray);
}

// MultArray(array1, array2);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
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

/*Сделал не для 4 на 4, а для квадратного массива любой размерности. Например, 8 на 8. Для НЕквадратного - допускает ошибки в середине где-то.*/

int[,] array62 = new int[8, 8];
int item = 1;
int row = 0;
int col = 0;
int lengthString = array62.GetLength(1);
int lengthColumn = array62.GetLength(0);
while (item < array62.Length)
{
    for (int i = 0; i < lengthString; i++) //пошел вправо, пока не закончится строка
    {
        array62[row, col] = item; // присвоил значение элементу
        item++; // увеличил значение назначаемое элементу
        col += 1; // шагнул на 1 элемент вправо
    }
    lengthColumn--; // уменьшил размер колонок, т.к. заполнил 1 ряд
    col--; // вернул курсор в границы матрицы, в строку
    row++; // опустился на 1 строку

    for (int i = 0; i < lengthColumn; i++) // пошел вниз, до конца столбца
    {
        array62[row, col] = item; // присвоил значение элементу
        item++; // увеличил значение назначаемое элементу
        row += 1; // шагнул на 1 элемент вниз
    }
    lengthString--; // уменьшил размер строк т.к. заполнил 1 столбец
    row -= 1; // вернул курсор в границы матрицы, т.к. опустился ниже столбца
    col -= 1; // шагнул на 1 элемент влево, т.к. правей ряд заполнен

    for (int i = 0; i < lengthString; i++) // пошел влево до конца строки
    {
        array62[row, col] = item; // присвоил значение элементу
        item++; // увеличил значение назначаемое элементу
        col--; // шагнул влево
    }
    lengthColumn--; // уменьшил размер колонок, т.к. заполнил один ряд
    row -= 1; // поднялся на одну строку вверх, т.к. ряд ниже заполнен
    col += 1; // вернул курсор в границы матрицы, т.к. ушел левее

    for (int i = 0; i < lengthColumn; i++) // пошел вверх
    {
        array62[row, col] = item; // присвоил значение элементу
        item++; // увеличил значение назначаемое элементу
        row--; //шагнул вверх
    }
    lengthString--; // уменьшил размер строк
    col++; // шагнул вправо
    row++; // вернул курсор в заполняемую область
}
Print2Arr(array62);