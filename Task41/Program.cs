// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите длину массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] sArr = new int[M];
int count = 0;
for (int i = 0; i < sArr.Length; i++ )
{
    Console.Write($"Введите элемент массива {i}: ");
    sArr [i] = Convert.ToInt32(Console.ReadLine());
    if (sArr[i] > 0)
    {
        count++;
    }
}
Console.Write("[");
Console.Write(string.Join(", ", sArr));
Console.WriteLine("]");
Console.Write($"Элементов > 0 введено {count}");