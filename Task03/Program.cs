﻿// Напишите программу, которая будет выдавать название дня недели по введенному номеру.
// 3 -> среда
// 5 -> пятница
// Алгоритм:
// 1. Получение "числа" в виде строки
// 2. Если "число" соответствует дню недели, вывод соответствующего дня недели.
// 3. Если "число" не является номером дня недели, сообщаем об ошибке.

Console.Write("Введите номер дня недели ");
string day = Console.ReadLine();
Console.Write("Вашему номеру дня недели соответствует ");
if (day == "1") 
{ 
    Console.WriteLine("понедельник");
}
else if (day == "2")
    {
        Console.WriteLine("вторник");
    }
    else if (day == "3")
        {
            Console.WriteLine("среда");
        }
        else if (day == "4")
            {
                Console.WriteLine("четверг");
            }
             else if (day == "5")
                {
                    Console.WriteLine("пятница");
                }
                else if (day == "6")
                    {
                        Console.WriteLine("суббота");
                    }
                    else if (day == "7")
                        {
                            Console.WriteLine("воскресенье");
                        }
                         else 
                        {
                            Console.WriteLine("ошибка. Простите, в нашем календаре нет такого дня недели.");
                        }