//Напишите программу, которая на вход принимает число и выдаёт его квадрат.
// Алгоритм:
// 1 На вход принимаем число.
// 2 Выдаем его квадрат.

//string input = Console.ReadLine();
//int number = Convert.ToInt32(input);
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;

Console.WriteLine($"Квадрат числа {number} = {square}");

