// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите размерность массива: ");
int SArr = Convert.ToInt32(Console.ReadLine());
int[] Arr = new int[SArr];
for (int i = 0; i < Arr.Length; i++)
{
    Arr[i] = new Random().Next(0, 100);
    Console.Write(Arr[i] + " ");
}