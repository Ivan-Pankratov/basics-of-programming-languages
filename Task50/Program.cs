﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
//
// 1 4 7 2
//
// 5 9 2 3
//
// 8 4 2 4
//
// 1 7 -> такого числа в массиве нет

Console.WriteLine("Введите позиции искомого элемента двумерного массива");
Console.Write("Номер строки = ");
int indexI = Convert.ToInt32(Console.ReadLine());
indexI = indexI - 1;
Console.Write("Номер столбца = ");
int indexJ = Convert.ToInt32(Console.ReadLine());
indexJ = indexJ - 1;

int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrix);

if (indexI >= matrix.GetLength(0) || indexJ >= matrix.GetLength(1) || indexI <=0 || indexJ <= 0 )
    {
        Console.WriteLine("Такого числа в массиве нет.");
    }
else Console.WriteLine($"Искомый элемент равен {matrix[indexI, indexJ], 4}");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}" + "  ");
        }
        Console.WriteLine(" |");
    }
}
