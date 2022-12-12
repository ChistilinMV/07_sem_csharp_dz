// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalDigitSum(int md, int nd)
{
    if (md == nd) return md;
    return NaturalDigitSum(md, nd - 1) + nd;
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > m) Console.WriteLine($"Сумма натуральных элементов в промежутке = {NaturalDigitSum(m, n)}");
else if (n < m) Console.WriteLine($"Сумма натуральных элементов в промежутке = {NaturalDigitSum(n, m)}");
else Console.WriteLine($"Числа равны");