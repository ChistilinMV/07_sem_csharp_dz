// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру
// этого числа.

string istr = "";
Console.WriteLine("Введите 3-х значное число");
while (istr.Length < 3 | istr.Length > 3 )
{
 istr = Console.ReadLine();
}
Console.Write("Вторая цифра введённого числа: "); Console.WriteLine(istr[1]);

