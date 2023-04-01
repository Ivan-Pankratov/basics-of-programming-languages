// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Ссылка на справочник о произведении матриц:
// https://studwork.ru/spravochnik/matematika/matricy/umnojenie-matric


int[,] matrix1 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(matrix2);
Console.WriteLine();
if (MultiplicationRule(matrix1, matrix2))
{
    int[,] result = MultiplicationMatrix(matrix1, matrix2);
    PrintMatrix(result);
}
else Console.WriteLine("Заданные матрицы перемножать нельзя.");

bool MultiplicationRule(int[,] matrix1, int[,] matrix2)
{
    return (matrix1.GetLength(1) == matrix2.GetLength(0));
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0);
    int columns = matrix2.GetLength(1);
    int[,] multMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            multMatrix[i, k] = MultiplicationElement(matrix1, matrix2, i, k);
        }
    }
    return multMatrix;
}

int MultiplicationElement(int[,] matrix1, int[,] matrix2, int i, int k)
{
    int result = 0;
    int count = matrix1.GetLength(1);
    for (int l = 0; l < count; l++)
    {
        result = result + matrix1[i, count - l - 1] * matrix2[count - l - 1, k];
    }
    return result;
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

