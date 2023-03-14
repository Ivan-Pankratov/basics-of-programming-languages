// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
//
// Алгоритм:
// 1. Ввод целых чисел a, b, c;
// 2. Определение max Если a < b, то, если a<c max = a,
//                      иначе max = c
// 3. Вывод max.
//

Console.Write("Введите целое число, a =  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число, b =  ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число, c =  ");
int c = Convert.ToInt32(Console.ReadLine());
if (a>b)
{ 
    if (a>c)
    {
        Console.Write($"Максимум = {a}");
    }
    else 
    {
        Console.Write($"Максимум = {c}");
    }
}
else
{
    if (b>c)
    {
        Console.Write($"Максимум = {b}");
    }
    else 
    {
        Console.Write($"Максимум = {c}");
    }
}




