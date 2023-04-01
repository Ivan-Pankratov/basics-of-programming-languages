//Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] array2d = CreateMatrixRndInt(4, 3, -10, 10);
PrintMatrix(array2d);

Console.WriteLine();
int row = MinSumElementesOfRowsInMatrix(array2d);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row}");

int MinSumElementesOfRowsInMatrix(int[,] matrix)
{
    int minRow = 0;
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++) sum = sum + matrix[0, j];
        int minSum = sum;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) sum = sum + matrix[i, j];
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    minRow = minRow + 1;
    return minRow;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                          // 0       1
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
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

