//Артём Макеев:  Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void SumPositiveAndNegativeElements(int[] arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumP += arr[i];
        }
        else
        {
            sumN += arr[i]; // sumNegative = sumNegative + array[i]
        }
    }
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] array = FillArrayWithRandomNumbers(10, -9, 9);

PrintArray(array);
SumPositiveAndNegativeElements(array, out int sumP, out int sumN);
System.Console.WriteLine($"Сумма положительных = {sumP}, отрицательных = {sumN}.");


System.Console.WriteLine();
System.Console.WriteLine();

// Артём Макеев: Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] newArray = FillArrayWithRandomNumbers(10, -9, 9);

PrintArray(newArray);

void NegArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }

    PrintArray(arr);
}

NegArray(newArray);
System.Console.WriteLine();
System.Console.WriteLine();

// Задача 33: Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

int[] myArray = FillArrayWithRandomNumbers(10, -2, 2);

void NumberInArray(int[] arr, int n)
{
    int i = 0;
    while (i < arr.Length)
    {
        if (arr[i] == n)
        {
            System.Console.Write($"Число {n} есть в массиве ");
            PrintArray(arr);
            break;
        }
        else i++;
    }
    if (i == arr.Length)
    {
        System.Console.Write($"Числа {n} нет в массиве ");
        PrintArray(arr);
    }
}

NumberInArray(myArray, -1);

// Артём Макеев: Задача 35: Задайте одномерный массив из 123
//  случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов.
//  В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


System.Console.WriteLine();
int[] numArr123 = FillArrayWithRandomNumbers(123, 1, 999);
System.Console.Write("numArr123: ");
PrintArray(numArr123);

int MyCount(int[] arr, int leftRange, int rightRange)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= leftRange && arr[i] <= rightRange) count++;
    }
    return count;
}

int newCount = MyCount(numArr123, 10, 99);
System.Console.WriteLine($"newCount = {newCount}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


System.Console.WriteLine();
int[] arrForSum = FillArrayWithRandomNumbers(11, 1, 10);
PrintArray(arrForSum);
int[] SumArray(int[] array)
{
    int median = array.Length/2;
    int[] newSumArray = new int[median];

    for(int i = 0;  i < median; i++)
    {
        newSumArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return newSumArray;
}

int [] newSum = SumArray(arrForSum);
PrintArray(newSum);