// Напишите цикл, который принимает на вход 2 числа (А и В) и 
// возводит число А в натуральную степень В
// 3, 5 -> 243
// 2, 4 -> 16

int Exponentiation(int a, int b)
{
    int exp = 1;
    if (b == 0)
    {
        exp = 1;
    }
    else
    {
        for (int i = 1; i <= b; i++)
        {
            exp = exp * a;

        }
    }
    return exp;
}

Console.Write("Введите целое число, a =  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число, b =  ");
int b = Convert.ToInt32(Console.ReadLine());
int exp = Exponentiation(a, b);
Console.WriteLine($"Возведение {a} в степень {b} равно {exp}");