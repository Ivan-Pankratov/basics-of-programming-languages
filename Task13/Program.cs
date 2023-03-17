// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
//
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число a:  ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a /= 100) == 0)
{
    Console.Write("В вашем числе нет третьей цифры");
}
else
{
    int b = a;
    int discharge = 1;
    while ((b /= 100) != 0)
    {
        b = b /= 10;
        discharge = discharge *10;
    }
    a = a /= discharge;
    int figure = a % 10;
    Console.Write($"Третья цифра {figure}");
}