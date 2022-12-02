// Напишите программу для подсчета количества цифр в числе с помощью рекурсии.
// 12345 -> 5

//это странно, но вначале я написал программу как она должна, по идее, работать, и толко потом понял как она действительно работает

int CountDigit(int num)
{
    if (num/10 == 0) return 1;
    else return CountDigit(num/10) + 1;
}
Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Цифр в числе {CountDigit(number)}");