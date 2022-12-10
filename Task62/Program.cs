// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix00(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j].ToString("00") + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillSpiralMatrix(int n)
{
    int[,] sMatrix = new int[n, n];

    int count = 1;
    int i = 0;
    int j = 0;

    while (count <= n * n)
    {
        sMatrix[i, j] = count;
        count++;
        if (i <= j + 1 && i + j < n - 1)
            j++;
        else if (i < j && i + j >= n - 1)
            i++;
        else if (i >= j && i + j > n - 1)
            j--;
        else
            i--;
    }
    return sMatrix;
}

int m = 4; // array size
int[,] array = FillSpiralMatrix(m);
PrintMatrix00(array);