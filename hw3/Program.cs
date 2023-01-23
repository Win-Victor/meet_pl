// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Задача 21


System.Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
if (num.Length != 5) // если надо чтоб только с 5-значными работали, то этот вариат 
{
    System.Console.WriteLine($"{num} не является пятизначным числом. Идите лесом.");
}
else if (num[0] + num[1] == num[4] + num[3])
{
    System.Console.WriteLine($"Да, {num} является палиндромом!");
}
else
{
    System.Console.WriteLine($"Нет, {num} не является палиндромом.");
}


// Если игнорируем 5-значность, то этот вариат
System.Console.WriteLine("Введите пятизначное число: ");
string? newNum = Console.ReadLine();
int median = newNum!.Length / 2;
string start = "";
string end = "";
int i = 0;
while (i < median)
{
    start += newNum[i];
    end += newNum[newNum.Length - (i + 1)];
    i++;
}
if (start == end)
    System.Console.WriteLine($"Да, {newNum} является палиндромом!");
else
    System.Console.WriteLine($"Ну, нет, {newNum} не является палиндромом!");



// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine();
System.Console.WriteLine("Введите поочередно координаты двух точек.");
System.Console.WriteLine("Сначала координаты первой точки.");
double[] coordA = new double[3];
double[] coordB = new double[3];

System.Console.Write("Введите X1: ");
coordA[0] = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите Y1: ");
coordA[1] = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите Z1: ");
coordA[2] = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine("Теперь введите координаты второй точки.");
System.Console.Write("Введите X2: ");
coordB[0] = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите Y2: ");
coordB[1] = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите Z2: ");
coordB[2] = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine($"Расстояние между точками A и B: {Math.Round(Math.Sqrt((Math.Pow(coordB[0] - coordA[0], 2)) + (Math.Pow(coordB[1] - coordA[1], 2) + (Math.Pow(coordB[2] - coordA[2], 2)))), 2)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine();
System.Console.Write("Введите число для производства кубов от 1 до этого числа: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 0) 
{
    System.Console.WriteLine("Число должно быть положительным.");
}
else
{
        for (int ind = 1; ind <= N; ind++)
            Console.WriteLine(Math.Pow(ind, 3));
}