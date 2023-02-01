// Двумерные массивы
string[,] table = new string[2, 5]; // создание двумерного массива [строки , столбцы]
// получается таблица из строк

int[,] matrix = new int[3, 4];
// таблица цифр из 5 строк и 8 столбцов

// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]


table[1, 2] = "слово"; // индекс строки и столбца; счет идет от 0

// печать массива

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        System.Console.Write($"-{table[rows, columns]}- ");
    }
    System.Console.WriteLine();
}



for (int rows = 0; rows < 3; rows++)
{
    for (int columns = 0; columns < 4; columns++)
    {
        System.Console.Write($"-{matrix[rows, columns]}- ");
    }
    System.Console.WriteLine();
}

for (int i = 0; i < matrix.GetLength(0); i++) // вместо явного указания кол-ва итераций используется поиск кол-ва элементов
// 0 - индексовый номер элемента массива - т.е. строки, 1 - столбцы. Кол-во столбцов и строк.
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        System.Console.Write($"-{matrix[i, j]}- ");
    }
    System.Console.WriteLine();
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // вместо явного указания кол-ва итераций используется поиск кол-ва элементов
                                                // 0 - индексовый номер элемента массива - т.е. строки, 1 - столбцы. Кол-во столбцов и строк.
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

PrintArray(matrix);

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); // каждый элемент матрицы заполнится элементом от 1 до 9 [1; 10)
        }
        System.Console.WriteLine();
    }
}

FillArray(matrix);
PrintArray(matrix);

// рекурентные соотношения - рекурсия

// Факториал

// 5! = 5 * 4 * 3 * 2 * 1
// 5! = 5 * 4!
//          4! = 4 * 3! 
// и т.д.

double Factorial (int n) // ограничения для int - 16, далее отрицательные значения
// можно заменить на double 
// 170! == 7,257415615307994E+306
// 171! == ?
{
    // 1! = 1
    // 0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}

// System.Console.WriteLine(Factorial(17));

// for (int i = 1; i < 200; i++)
// {
//     System.Console.WriteLine($"{i}!: {Factorial(i)}");
// }

double Fib(int n)
{
    if(n == 1 || n == 2) return 1;

    return Fib(n - 1) + Fib(n - 2);
}

System.Console.WriteLine(Fib(6));

for (int i = 1; i < 60; i++) // после 41 виснет
{
    System.Console.WriteLine($"Fib-{i}: {Fib(i)}");
}