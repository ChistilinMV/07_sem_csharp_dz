// Задача 38: Задайте массив вещественных(тип double) чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// ! в решении вычисляется разница фактических элементов массива без учёта округления при выводе элементов массива

double GetRandomDouble(double min, double max)
{ 
    Random random = new Random();
    return random.NextDouble() * (max - min) + min;
}

double[] FillArray(int size)
{
    double[] arr = new double[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetRandomDouble(1,100);
    }
    return arr;
}

void PrintArr (double [] arr4prn)
{
    Console.Write("[");
    for (int i = 0; i < arr4prn.Length; i++)
    {
        Console.Write("{0,6:F2}", arr4prn[i]);
    }
    Console.Write("]");
}

double FindMaxDouble (double [] farray)
{
    double maxnum = farray[0];
    for (int i = 0; i < farray.Length; i++)
    {
        if (farray[i] > maxnum) { maxnum = farray[i];}
    }
    return maxnum;
}

double FindMinDouble (double [] farray)
{
    double minnum = farray[0];
    for (int i = 0; i < farray.Length; i++)
    {
        if (farray[i] < minnum) { minnum = farray[i];}
    }
    return minnum;
}

Console.Write("Введите длину массива: ");
int sarr = Convert.ToInt32(Console.ReadLine());
double[] array = FillArray(sarr);
PrintArr(array);
Console.WriteLine();
Console.WriteLine("{0,6:F2}", FindMaxDouble(array) - FindMinDouble(array));
