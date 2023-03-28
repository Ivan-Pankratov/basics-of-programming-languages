// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите три  числа");
Console.Write("a: "); 
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b: "); 
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c: "); 
int c = Convert.ToInt32(Console.ReadLine());
Triangle (a, b, c);

void Triangle(int a, int b, int c)
{
    if (a < b+c && b < a+c && c < a+b ) 
    {
        Console.WriteLine("Такой треугольник существует");
    }
    else
    {
        Console.WriteLine("Такой треугольник не существует");
    }
}