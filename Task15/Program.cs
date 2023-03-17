//  Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
//
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели  ");
string day = Console.ReadLine();
Weekend(day);

void Weekend(string day)
{
    if (day == "6")
    {
        Console.WriteLine("Выходной");
    }

    else
    { 
        if (day == "7")
    {
        Console.WriteLine("Выходной");
    }
       else {Console.WriteLine("Невыходной");}
    }
}