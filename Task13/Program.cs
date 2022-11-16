// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число:");
string istr = Console.ReadLine();
if (istr.Length >= 3)
{
    Console.Write("Третья цифра введённого числа: "); Console.WriteLine(istr[2]);
}
else {Console.WriteLine("Третьей цифры нет");}