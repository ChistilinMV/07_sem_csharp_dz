// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int N = 5;
Console.WriteLine($"Введите {N}-ти значное число: ");
string istr = Console.ReadLine();
if (istr.Length == N)
{
 if (Convert.ToInt32(istr[0]) == Convert.ToInt32(istr[N-1]) & Convert.ToInt32(istr[1]) == Convert.ToInt32(istr[N-2]))
 {
    Console.WriteLine("Да, число полинром");
 }
 else
 {
    Console.WriteLine("Нет, число НЕ полинром");
 }
}
else Console.WriteLine("Ошибка! Число должно быть пятизначным.");
