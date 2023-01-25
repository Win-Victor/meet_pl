int InputNumber(string message)
{
    System.Console.WriteLine("InputNumber");
    while (true)
    {
        int number;
        System.Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out number))
        {
            return number;
        }
        else System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
    }
}

int newNumber = InputNumber("Enter number ");
System.Console.WriteLine($"newNumber = {newNumber}");


// Артём Макеев: Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

void LenNum(int N)
{
    System.Console.WriteLine("LenNum");
    // System.Console.WriteLine(N);
    string strNumber = Convert.ToString(N);
    System.Console.WriteLine($"количество цифр в числе {N}: {strNumber.Length}");
}

LenNum(InputNumber("Введите число для определения кол-ва чисел в нем: "));

// Артём Макеев: Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MyFactorial()
{
    System.Console.WriteLine("MyFactorial");
    {
        int N;
        while (true)
        {
            System.Console.Write("Enter N: ");
            if (int.TryParse(Console.ReadLine(), out N))
            {
                // System.Console.WriteLine(N);
                int res = 1;
                for (int i = 1; i <= N; i++) res *= i;
                return res;
            }
            else System.Console.WriteLine("Введено некорректное число, попробуйте еще раз.");
        }
    }

}

int newFactorial = MyFactorial();
System.Console.WriteLine(newFactorial);


// Артём Макеев: Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Get_1_2_Array(int length)
{
    System.Console.WriteLine("Get_1_2_Array");
    int [] array = new int[length];
    for (int i = 0; i < length; i++) array[i] = new Random().Next(0, 2);
    // for (int i = 0; i < length; i++) System.Console.Write($"{array[i]} "); // вывод через цикл
    System.Console.WriteLine($"[{string.Join(", ", array)}]"); // вывод через метод Join
}

Get_1_2_Array(8);
System.Console.WriteLine();
Get_1_2_Array(8);
System.Console.WriteLine();
Get_1_2_Array(8);