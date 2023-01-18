// Программа, которая определяет большее из цифр двузначного числа

// Random rand = new Random(); // - объявление объекта класса Random
// int randomNumber = rand.Next(10, 100); // rand -  класса, 
// // метод этого класса Next создает числа от 10 д 100 в двнном случае
// // от первой цифры включительно до второй невключительно
// // randomNumber - переменная, создаваемая объектом 
// System.Console.WriteLine(randomNumber);

// System.Console.Write($"Большая цифра числа {randomNumber}: ");
// if(randomNumber/10 > randomNumber%10)
// {
//     System.Console.Write(randomNumber/10);
// }
// else
//     System.Console.Write(randomNumber%10);


// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random(); 
int randomNumber1 = rand.Next(100, 1000);
System.Console.WriteLine($"число {randomNumber1} без второй цифры: {((randomNumber1/100)*10)+randomNumber1%10}");


// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

System.Console.WriteLine("Введите 2 числа для проверки кратности");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int remainder = num1 % num2;

if (remainder == 0)
{
    System.Console.WriteLine($"{num1} кратно {num2}");
}
else
{
    System.Console.WriteLine($"{num1} не кратно {num2}. Остаток: {remainder}");
}

// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

System.Console.WriteLine("Введите 2 числа");
int num11 = Convert.ToInt32(Console.ReadLine());
int num22 = Convert.ToInt32(Console.ReadLine());
if ((num11*num11) == num22)
{
    System.Console.WriteLine($"{num22} является квадратом {num11}");
}
else
{
    System.Console.WriteLine($"{num22} не является квадратом {num11}");
}



// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

System.Console.WriteLine("Введите число");
int num111 = Convert.ToInt32(Console.ReadLine());
if (num111 % 7 == 0 && num111 % 7 == 0) 
{
    System.Console.WriteLine($"{num111} кратно одновременно 7 и 23");
}
else
{
    System.Console.WriteLine($"{num111} не кратно одновременно 7 и 23");
}