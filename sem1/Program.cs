// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.Write("Eneter 1 number: ");
// int num1  = Convert.ToInt32(Console.ReadLine());
// Console.Write("Eneter 2 number: ");
// int num2  = Convert.ToInt32(Console.ReadLine());

// if ((num2 * num2) == num1)
// {
//     System.Console.WriteLine($"Yes, {num1} является квадратом {num2}");
// }
// else
// {
//     System.Console.WriteLine($"No, {num1} не является квадратом {num2}");
// }


// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Укажите цифру от 1 до 7 соответствующую дню недели: ");
// string weekday = Console.ReadLine();
 
// switch (weekday)
// {
//     case "1":
//         Console.WriteLine("Понедельник");
//         break;
//     case "2":
//         Console.WriteLine("Вторник");
//         break;
//     case "3":
//         Console.WriteLine("Среда");
//         break;
//     case "4":
//         Console.WriteLine("Четверг");
//         break;
//     case "5":
//         Console.WriteLine("Пятница");
//         break;
//     case "6":
//         Console.WriteLine("Суббота");
//         break;
//     case "7":
//         Console.WriteLine("Воскресенье");
//         break;
//     default:
//         Console.WriteLine("Вводите от 1 до 7");
//         break;        
// }

// Задача №5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// System.Console.Write("Введите одно число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num_neg = num * -1;

// while (num_neg <= num)
// {
//     Console.Write(num_neg + ",");
//     num_neg++;
// }

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

System.Console.Write("Введите трёхзначное число: ");
int myNum = Convert.ToInt32(Console.ReadLine());
if (99 > myNum || myNum > 999)
{
    System.Console.Write($"Вы ввели {myNum}. Это не трехзначное число");   
}
else
{
    System.Console.Write($"Последняя цифра: {myNum % 10}.");
}
