// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число А: ");
int num01 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num02 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число С: ");
int num03 = Convert.ToInt32(Console.ReadLine());
int max=num01;
if (num02>max) {max=num02;}
if (num03>max) {max=num03;}
Console.Write($"Максимальное число: {max}");