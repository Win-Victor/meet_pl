/* 
Урок 4. Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

void MyPow(int a, int b)
{
    int res = a;
    for (int count = 1; count < b; count++) res *= a;
    System.Console.WriteLine($"Возведение числа {a} в степень {b}: {res}.");
}

MyPow(3, 5);
MyPow(2, 4);
MyPow(2, 10);

System.Console.WriteLine();

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


void SumNumbers()
{
    System.Console.Write("Введите натуральное число: ");
    string num = System.Console.ReadLine();
    int res = 0;
    for (int count = 0; count < num.Length; count++) res += Convert.ToInt32(Convert.ToString(num[count]));
    System.Console.WriteLine($"Сумма цифр в введенном числе {num}: {res}");
}

SumNumbers();

System.Console.WriteLine();

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] GetArray()
{
    int[] array = new [8];
    System.Console.WriteLine(array);
}