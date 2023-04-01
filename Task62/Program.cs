// Задача 62. Напишите программу, 
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Write("Введите длину строки массива: ");
int size = Convert.ToInt32(Console.ReadLine());
while (size <= 0)
{
    Console.WriteLine("Вы ввели неверное число. Попробуйте снова.");
    Console.Write("Пожалуйста, введите длину строки массива: ");
    size = Convert.ToInt32(Console.ReadLine());
}
int[,] matrix = CreatingSquareArray(size);
PrintMatrix(matrix);

int[,] CreatingSquareArray(int size)
{
    int[,] array = new int[size, size];
    if (size % 2 != 0)
    {
        int l = size * size;
        int i = size / 2;
        int j = size / 2;
        array[i, j] = l;
    }
    if (size == 1) return array;
    else
    {
        int rowNumber = 0;
        int firstElement = 1;
        for (int i = size; i > 1; i -= 2)
        {
            RoundArray(rowNumber, firstElement, array);
            rowNumber++;
            firstElement = firstElement + i * 4 - 4;
        }
        return array;
    }
}

void RoundArray(int rowNumber, int firstElement, int[,] array)
{
    int size = array.GetLength(0) - rowNumber * 2;
    int i = 0 + rowNumber;
    int j = 0 + rowNumber;
    for (int m = 0; m < size; m++)
    {
        array[i, j + m] = firstElement + m;
        array[i + m, j + size - 1] = firstElement + size + m - 1;
        array[i + size - 1, j + size - m - 1] = firstElement + 2 * size + m - 2;
        if (m < size - 1)
        {
            array[i + size - m - 1, j] = firstElement + 3 * size + m - 3;
        }
    }
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