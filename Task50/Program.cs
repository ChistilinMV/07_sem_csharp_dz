// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] Fill2DArray(int sm, int sn, int rndmin, int rndmax)
{
    int[,] matrix = new int[sm, sn];
    for (int i = 0; i < sm; i++)
    {
        for (int j = 0; j < sn; j++)
        {
            matrix[i, j] = new Random().Next(rndmin, rndmax);
        }
    }
    return matrix;
}
void Print2DArray(int[,] matrix, int markposm, int markposn)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (markposm >= 0 & markposn >= 0 & markposm == i & markposn == j)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("{0,3:d}", matrix[i, j] + " ");
                Console.ResetColor();
            }
            else Console.Write("{0,3:d}", matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int elmin = 0;
int elmax = 99;
Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Fill2DArray(m, n, elmin, elmax);
Print2DArray(myArray, -1, -1);
Console.WriteLine("Введите позицию в массиве m1 x n1");
Console.Write("Введите  m: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n1 = Convert.ToInt32(Console.ReadLine());
if (n1 < n & m1 < m & n1 >= 0 & m1 >= 0)
{
 Print2DArray(myArray, m1, n1);
}
else Console.WriteLine("Ошибка! Такого числа в массиве нет");