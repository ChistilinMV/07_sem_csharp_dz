// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях(индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int size)
{
    
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-1000,1001);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int sarr = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(sarr);
Console.Write("[");
Console.Write(string.Join(", ", array));
Console.WriteLine("]");
int summ = 0;
for (int i = 1; i < sarr; i+=2)
{
    summ+=array[i];
}
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {summ}");