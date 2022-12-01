// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossP(double k1, double b1, double k2, double b2)
{
double x = (b2-b1)/(k1-k2);
double y = (k1*(b2-b1))/(k1-k2)+b1;
if ((k1 == k2) && (b1 == b2))
{
Console.WriteLine("Прямые совпадают");
}
else if (k1 == k2)
{
Console.WriteLine("Прямые параллельны");
}
else
{
Console.Write($"Прямые пересекаются в точке: ({x}; {y})");
}
}

Console.Write("Введите координату X точки b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X точки k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

CrossP(k1,b1,k2,b2);