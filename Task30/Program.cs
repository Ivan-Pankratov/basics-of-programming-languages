﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
ArrayGenerator(array);
PrintArray(array);


void PrintArray(int[] arr)
{
 for (int i = 0; i < arr.Length; i++)
 {
    Console.Write(arr[i] + " ");
 }
}

void ArrayGenerator(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(0, 2);          //генератор случ чисел  0 или 1
    }
}
