// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

/* Функция принимает два неотрицательных целых числа в качестве параметров и возвращает натуральное число, 
обозначается  A(m,n) */
// A(m,n)
/* A(0,n) = n+1
A(m,0) = A(m-1,1)
A(m,n) = A(m-1,A(m,n-1)) */

 
Console.Clear();
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Function (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Function(m - 1, 1);
    if (m > 0 && n > 0) return Function(m - 1, Function(m, n - 1));
return Function(m, n);
}
if (M < 0 && N < 0) // Это функция с двумя аргументами, каждому из которых может быть присвоено любое неотрицательное целое число.
{
    Console.WriteLine("Числа M и N не могут быть отрицательными!");
}
if (M < 0 || N < 0)
{
    Console.WriteLine("Ни одно из чисел не должно быть отрицательным!");
}
else
{
    Console.WriteLine(Function(M,N));
}

