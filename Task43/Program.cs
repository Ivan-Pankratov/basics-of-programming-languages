//  Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// 
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициент и число уравнения первой прямой y = k1 * x + b1 ");
Console.Write("k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент и число уравнения второй прямой y = k2 * x + b2 ");
Console.Write("k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
IntersectionPoint(k1, b1, k2, b2);

void IntersectionPoint(int k1, int b1, int k2, int b2)
{
    if (k1 == k2)
    {
        Console.WriteLine("Заданные прямые параллельны");
    }
    else
    {
        double x = b2 - b1;
        x = x / (k1 - k2);
        double y = k1 * x + b1;
        double xRound = Math.Round(x, 2);
        double yRound = Math.Round(y, 2);
        Console.WriteLine($"Координаты точки пересечения прямых: ({xRound}; {yRound})");
    }
}
