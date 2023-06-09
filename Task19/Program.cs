﻿// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//
// 14212 -> нет
//
// 12821 -> да
//
// 23432 -> да

// Примечание: 
// 1. Программа сделана на произвольное число. Не обязательно пятизначное.
// 2. Отрицательное число не может быть палиндромом, так как при перевороте последним символом становится "-", 
//    а первым "цифра"

Console.Write("Введите число  ");
string number = Console.ReadLine();
if (Palindrome(number))
{
    Console.WriteLine(" это палиндром!");
}
else 
{
    Console.WriteLine(" это не палиндром!");
}

bool Palindrome(string number)
{
    int length = number.Length;
    string pal = System.String.Empty;
    for (int i = 0; i < length; i++)
    {
        pal = (pal + number[length - i - 1]);
    }
    return (number == pal);
}
