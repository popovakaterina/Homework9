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

int Function (int i, int j)
{
    if (i == 0) return j + 1;
    if (i > 0 && j == 0) return Function(i - 1, 1);
    if (i > 0 && j > 0) return Function(i - 1, Function(i, j - 1));
return Function(i, j);
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

