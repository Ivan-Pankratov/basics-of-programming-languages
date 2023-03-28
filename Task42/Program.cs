// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int result = DecToBin(number1);
Console.WriteLine($" => {result}");

int DecToBin(int number)
{
    if (number == 0 || number == 1)
    {
        return number;
    }
    else
    {
        return (DecToBin(number / 2) * 10 + (number % 2));
    }
}