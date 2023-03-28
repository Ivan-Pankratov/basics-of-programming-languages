﻿//  Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);
 Console.WriteLine();
double[] array = ArithmeticMeanArray(array2d);
PrintArray(array);

double[] ArithmeticMeanArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int size = matrix.GetLength(1);
    double[] array = new double[size];
    for (int j = 0; j < size; j++)
    {
        double sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = matrix[i, j] + sum;
        }
        double num = sum / rows;
        array[j] = Math.Round(num, 1);
    }
    return array;
}


void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i],5}" + "  ");
        }
        else
        {
            Console.WriteLine($"{array[i],5}" + "   ]");
        }
    }
}

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
            Console.Write($"{matrix[i, j],5}" + "  ");
        }
        Console.WriteLine(" |");
    }
}
