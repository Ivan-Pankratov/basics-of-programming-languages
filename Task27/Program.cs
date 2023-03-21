// Напишите программу, которая принимает на вход число, а выдаёт
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10

void SumNumb(int number)
{
    int sum = 0;
    if (number < 0)
    {
        number = -number;
    }
    while (number > 0)
    {
        sum = sum + (number % 10);
        number = number /= 10;
    }
    Console.WriteLine($"Сумма цифр равна {sum}");
}

Console.Write("Введите целое число, a =  ");
int number = Convert.ToInt32(Console.ReadLine());
SumNumb(number);