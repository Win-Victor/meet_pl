// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int RecSumMtoN(int M, int N)
{
    if(N < M)
    {
        int temp = M;
        M = N;
        N = temp;
    }
    if(M == N) return M;
    else return M + RecSumMtoN(M + 1, N);
}

int sum1 = RecSumMtoN(1, 10);
System.Console.WriteLine(sum1);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akerman(int m, int n)
{
if (m == 0) return n + 1;
if (m > 0 && n == 0) return Akerman(m - 1, 1);
if (m > 0 && n > 0) return Akerman(m-1, Akerman(m, n -1));
return 0;
}

int n = Akerman(2, 3);
System.Console.WriteLine(n);
int n1 = Akerman(3, 2);
System.Console.WriteLine(n1);