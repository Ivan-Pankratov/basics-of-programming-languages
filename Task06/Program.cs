﻿//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// Алгоритм:
// Ввод числа
// Сравниваем остаток от деления на 2 с 0 и принимаем решение чёт/нечет.
// Вывод да/нет.

Console.Write("Введите целое число, a =  ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
    Console.WriteLine($"{a} - чётное число");
else
{
    Console.WriteLine($"{a} - не является чётным числом");
}
