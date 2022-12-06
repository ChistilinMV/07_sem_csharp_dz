// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + myArray[i,j];
    }
    Console.Write(sum/n+"; ");
}