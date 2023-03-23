// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
//
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.Write("Введите чмсло N ");
int n = Convert.ToInt32(Console.ReadLine());
ТhirdDegree(n);

void ТhirdDegree(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"{i,3} ->  {i * i * i,6}");
    }
}
