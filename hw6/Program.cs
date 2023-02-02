// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.Write("Cколько чисел Вы планируете вводить? ");
int m = Convert.ToInt32(Console.ReadLine());
int i = 1;
int count = 0;
int number;
while (i <= m)
{
    System.Console.Write($"Введите {i}-e число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
    i++;
}
System.Console.WriteLine($"Было введено чисел: {count}, больших 0.");


// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/* 
y = k1 * x + b1 
y = k2 * x + b2

k1x + b1 = k2x + b2
k1x - k2x = b2 - b1
(k1 - k2) * x = b2 - b1
x = (b2 - b1) / (k1 - k2) 
*/

System.Console.WriteLine("Введите все переменные. k1 и k2 не должны равняться.");

var p = new Dictionary<string, double>()
{
    {"b1", 0},
    {"k1", 0},
    {"b2", 0},
    {"k2", 0}
};

foreach (var point in p)
{
    Console.Write($"Введите {point.Key}: ");
    p[point.Key] = Convert.ToInt32(Console.ReadLine());
}
if (p["k1"] == p["k2"]) System.Console.WriteLine("k1 == k2. Данная система не имеет решения.");
else
{
    double x = (p["b2"] - p["b1"]) / (p["k1"] - p["k2"]);
    double y = p["k1"] * ((p["b2"] - p["b1"]) / (p["k1"] - p["k2"])) + p["b1"];
    System.Console.Write($"({Math.Round(x, 3)}; {Math.Round(y, 3)})");
}
