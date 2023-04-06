// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
while (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Ошибка ввода чисел: есть отрицательное. Попробуйте снова.");
    Console.Write("Введите неотрицательное число M: ");
    number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите неотрицательное число N: ");
    number2 = Convert.ToInt32(Console.ReadLine());
}

int ackerman = Ackerman(number1, number2);
Console.WriteLine(ackerman);

int Ackerman(int n, int m)
{
    while (n != 0)
    {
        if (m == 0) m = 1;
        else m = Ackerman(n, m - 1);
        n--;
    }
    return m + 1;
}
