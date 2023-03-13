// Программа, которая принимает на вход одно целое число (N),
// а на выходе даёт все целые числа на промежутке от - N до N
// 2 -> -2. -1. 0. 1. 2
// Алгоритм:
// ввод числа
//
//

Console.Write("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
while (count <= number)
{
    Console.Write($"{count}, ");
    count++;
}