// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Алгоритм:
// 1. ВВод переменных a и b;
// 2. Если a > b, печатаем  max = a, min = b
//    иначе печатаем  max = b, min = a
//
Console.Write("Введите целое число, a =  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число, b =  ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) 
{   
    Console.WriteLine($"max = {a}, min = {b}");
}
else 
{
    Console.WriteLine($"max = {b}, min = {a}");
}
