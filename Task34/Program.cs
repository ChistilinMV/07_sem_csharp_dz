// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{
    
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1,1000);
    }
    return arr;
}

Console.Write("Введите длину массива: ");
int sarr = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(sarr);
Console.Write("[");
Console.Write(string.Join(", ", array));
Console.Write("]");
int count = 0;
for (int i = 0; i < sarr; i++)
{
    if (array[i] % 2 == 0) { count++;}
}
Console.WriteLine($" -> Чётных чисел {count}");