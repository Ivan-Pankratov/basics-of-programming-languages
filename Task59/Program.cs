// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] array2D = CreateMatrix(5, 5, 0, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] coords = CoordinatesMinimumMatrix(array2D);
Console.WriteLine($"Индексы минимума: {coords[0]}, {coords[1]}");
int[,] newArray2D = NewMatrix(array2D, coords);
PrintMatrix(newArray2D);

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
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
        Console.Write("|");
        Console.WriteLine();
    }
}

int[] CoordinatesMinimumMatrix(int[,] matrix)
{
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[minRow, minColumn])
            {
                minRow = i;
                minColumn = j;
            }
        }
    }
    return new int[] { minRow, minColumn };
}

int[,] NewMatrix(int[,] matrix, int[] coords)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == coords[0]) continue;
        else
        {
            int l = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == coords[1]) continue;
                else
                {
                    newMatrix[k, l] = matrix[i, j];
                    l++;
                }
            }
            k++;
        }
    }
    return newMatrix;
}