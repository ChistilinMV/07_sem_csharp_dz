// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double GetRandomDouble(double min, double max, int round)
{ 
    Random random = new Random();
    return Math.Round(random.NextDouble() * (max - min) + min, round);
}

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [m,n];
int digimin = -9; //minimum
int digimax = 10; //& maximum base for random generator
int digiround = 1; //decimal places for rounding
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = GetRandomDouble(digimin,digimax,digiround);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();
}
