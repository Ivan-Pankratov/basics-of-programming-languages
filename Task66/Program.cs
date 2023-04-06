// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// 
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
while (number1 <= 0 || number2 <= 0)
{
    Console.WriteLine("Ошибка ввода чисел: есть не натуральное. Попробуйте снова.");
    Console.Write("Введите натуральное число M: ");
    number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число N: ");
    number2 = Convert.ToInt32(Console.ReadLine());
}

if (number1 > number2)
{
    int k = number1;
    number1 = number2;
    number2 = k;
}
Console.WriteLine(SumNumbers(number1, number2));

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return n + SumNumbers(m, n - 1);
}