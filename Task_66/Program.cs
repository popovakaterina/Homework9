//Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int summ = 0;
for (int i = M; i <= N; i++) 
{
    if (i>0)
    {
        summ = summ+i;
    }      
}
Console.WriteLine("Сумма натуральных чисел промежутка от M до N = " +summ);
