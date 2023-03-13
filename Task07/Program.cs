// Программа на вход принимает трёхзначное число,
// а на выходе даёт последнюю цифру этого числа
// Алгоритм:
// Ввод числа
// Находим остаток от деления на 10
// Выводим этот остаток

Console.Write("Введите трёхзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
int numLast = number % 10;
Console.Write($"Последняя цифра {numLast}");
