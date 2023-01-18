// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// // какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    Console.WriteLine($"Max = {num1}.");
}
else if (num1 < num2)
{
    Console.WriteLine($"Max = {num2}.");
}
else
{
    Console.WriteLine($"Введенные числа равны. Max = {num1}.");
}

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт 
// // максимальное из этих чисел.

// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

Console.Write("Введите первое число: ");
int num41 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num42 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num43 = Convert.ToInt32(Console.ReadLine());

if (num41 >= num42)
{
    if (num41 >= num43)
    {
        Console.WriteLine($"Max = {num41}.");
    }
    else
    {
        Console.WriteLine($"Max = {num43}.");
    }
}
else if (num42 >= num43)
{
    Console.WriteLine($"Max = {num42}.");
}
else
{
    Console.WriteLine($"Max = {num43}.");
}


// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// // является ли число чётным (делится ли оно на два без остатка).

// // 4 -> да
// // -3 -> нет
// // 7 -> нет

Console.Write("Введите число: ");
int num6 = Convert.ToInt32(Console.ReadLine());

if (num6 % 2 == 0) {
    Console.Write("Да.");
}
else
    Console.Write("Нет.");

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int num8 = Convert.ToInt32(Console.ReadLine());
int newNum = 2;

while (newNum <= num8) 
{
    Console.Write(newNum + ", ");
    newNum+=2;
}