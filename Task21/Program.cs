// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// 
// A (3,6,8); B (2,1,-7), -> 15.84
//
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки А");
Console.Write("x1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("x2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());

double distanc = Distanc3D(x1Coordinate, y1Coordinate, z1Coordinate, x2Coordinate, y2Coordinate, z2Coordinate);
double distancRound = Math.Round (distanc, 2);
Console.WriteLine($"Расстояние между точками равно {distancRound}");

double Distanc3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    int z = z2 - z1;
    double line = Math.Sqrt(x*x + y*y + z*z);
    double lineRound = Math.Round(line, 2);
    return lineRound;
}