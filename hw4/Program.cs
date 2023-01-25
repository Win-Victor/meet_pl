/* 
Урок 4. Функции
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
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
    System.Console.WriteLine("SumNumbers");
    while (true)
    {
        System.Console.Write("Введите натуральное число: ");
        int num;
        if (int.TryParse(Console.ReadLine(), out num))
        {
            int res = 0;
            string numStr = Convert.ToString(num);
            for (int count = 0; count < numStr.Length; count++) res += Convert.ToInt32(Convert.ToString(numStr[count]));
            System.Console.WriteLine($"Сумма цифр в введенном числе {numStr}: {res}");
            break;
        }
        else System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
    }
    
    // string num = System.Console.ReadLine();
  

}

SumNumbers();

// System.Console.WriteLine();

// /*
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// */

void GetArray(int min_el, int max_el, int length_arr)
{
    int[] array = new array [length_arr];
    for(int i = 0; i < length_arr; i++) array[i] = new Ro
}