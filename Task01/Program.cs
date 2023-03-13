// Напишите программу, которая на ввод принимает 2 числа 
// и проверяет, является ли первое квадратом второго.
// а = 9, b = 3 -> да
// а = 2, b = 10 -> нет
// Алгоритм:
// 1. Ввод первого числа a, ввод второго числа b;
// 2. Находим square = b*b;
// 3. Если верно, что (а = square), то печатаем "да, иначе печатаем "нет".

Console.Write("Введите целое число, a =  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число, b =  ");
int b = Convert.ToInt32(Console.ReadLine());

int square = b * b;
if (a==square) 
{   
    Console.WriteLine($"a=b*b -> да");
}
else 
{
    Console.WriteLine($"a<>b*b -> нет");
}