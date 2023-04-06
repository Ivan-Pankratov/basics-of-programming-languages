// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число N: ");

int number = Convert.ToInt32(Console.ReadLine());
while (number <= 0)
{
    Console.WriteLine("Вы ввели неверное число. Попробуйте снова.");
    Console.Write("Пожалуйста, введите натуральное число N: ");
    number = Convert.ToInt32(Console.ReadLine());
}
RowNumbers(number);

void RowNumbers(int n)
{
    if (n == 0) return;
    Console.Write($"{n} ");
    RowNumbers(n - 1);
}

