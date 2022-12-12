// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ack(int m, int n)
{
    // классический метод
    // if (m == 0) return n + 1;
    // if (m > 0 && n == 0) return Ack(m - 1, 1);
    // if (m > 0 && n > 0) return Ack(m - 1, Ack(m, n - 1));
    // return 1;

    // более эффективная частично итерационная реализация
    while (m != 0)
    {
        if (n == 0) n = 1;
        else n = Ack(m, n - 1);
        m = m - 1;
    }
    return n + 1;
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 0 & n > 0) Console.WriteLine($"Функция Аккермана для M={m}, N={n} = {Ack(m, n)}");
else Console.WriteLine($"Числа должны быть неотрицателные");