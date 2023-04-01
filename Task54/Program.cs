// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array2d = CreateMatrixRndInt(4, 3, -10, 10);
PrintMatrix(array2d);

Console.WriteLine();
SortElementsOfRowsInMatrix(array2d);
PrintMatrix(array2d);

void SortElementsOfRowsInMatrix(int[,] matrix)
{
    int max = matrix[0, 0];
    int rowLength = matrix.GetLength(0);
    int columnLength = matrix.GetLength(1);
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < columnLength; j++)
        {
            max = matrix[i, j];
            int k = j + 1;
            while (k < columnLength)
            {
                if (matrix[i, k] > max)
                {
                    matrix[i, j] = matrix[i, k];
                    matrix[i, k] = max;
                    k++;
                    max = matrix[i, j];
                }
                else
                {
                    k++;
                }
            }
        }
    }
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
