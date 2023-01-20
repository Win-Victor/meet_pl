// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Random rand = new Random();
int randNum = rand.Next(100, 1000);

System.Console.WriteLine($"Новое число: {randNum}.");
System.Console.WriteLine($"Её вторая цифра: {(randNum / 10) % 10}.");



// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число для определения ее 3й цифры:");
int num13 = Convert.ToInt32(Console.ReadLine());
if (num13 < 100)
{
    System.Console.WriteLine($"У числа {num13} нет 3 цифры.");
}
else if (num13 > 999)
{
    while (num13 > 999)
        num13 /= 10;
    System.Console.WriteLine($"Третья цифра нового числа: {num13 % 10}.");
}
else
    System.Console.WriteLine($"Третья цифра нового числа: {num13 % 10}.");



// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, соответствующую дню недели (1 - 7): ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.Write("Нет, Понедельник - не выходной день!");
        break;
    case 2:
        Console.Write("Нет, Вторник - не выходной день!");
        break;
    case 3:
        Console.Write("Нет, Среда - не выходной день!");
        break;
    case 4:
        Console.Write("Нет, Четверг - не выходной день!");
        break;
    case 5:
        Console.Write("Нет, Пятнница - не выходной день!");
        break;
    case 6:
        Console.Write("Да, Суббота - выходной день!");
        break;
    case 7:
        Console.Write("Да, Воскресенье - выходной день!");
        break;
    default:
        Console.Write("В неделе 7 дней с 1го по 7й.");
        break;
}