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

void PrintArrayInt(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void PrintArrayDouble(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

double[] FillArrayWithDoubleRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double temp = rand.Next(leftRange, rightRange + 1) + rand.NextDouble();
        arr[i] = temp;
    }
    return arr;
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] arr34 = FillArrayWithRandomNumbers(10, 100, 999);

PrintArrayInt(arr34);

void CountEvenAndOddNumbers(int[] array)
{
    int countEven = 0;
    int countOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) countEven++;
        else countOdd++;
    }

    System.Console.WriteLine($"Четных чисел в массиве: {countEven}, нечетных: {countOdd}.");
}

CountEvenAndOddNumbers(arr34);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.WriteLine();

int[] arr36 = FillArrayWithRandomNumbers(10, -10, 10);
PrintArrayInt(arr36);

int SumNumbersWithOddIndex(int[] array)
{
    int sumNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sumNumbers += array[i];
    }
    return sumNumbers;
}

int newSum = SumNumbersWithOddIndex(arr36);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {newSum}.");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

System.Console.WriteLine();

double[] arr38 = FillArrayWithDoubleRandomNumbers(10, -10, 10);

PrintArrayDouble(arr38);

void DiffBetweenMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    System.Console.WriteLine($"Max: {Math.Round(max, 3)} Min: {Math.Round(min, 3)}. Diff: {Math.Round((max - min), 3)}");
}

DiffBetweenMinMax(arr38);