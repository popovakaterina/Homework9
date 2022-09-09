// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N

Console.Clear();
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nМассив натуральных чисел: ");
for (int i = M; i <= N; i++) 
{
    if (i>0)
    {
       Console.Write( i + " " ); 
    }   
}

