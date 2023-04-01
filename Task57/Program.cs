// //Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// Метод выводит текстовое сообщение на экран.

Console.Clear();
int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);

int[] array = ChangeMatrix(array2d);

Array.Sort(array);
Dictionary(array);

void Dictionary(int[] array)
{
    Console.WriteLine("Частотный словарь массива:");
    int element = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == element)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{element} встречается {count} раз");
            element = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{element} встречается {count} раз");
}

int[] ChangeMatrix(int[,] matrix)
{
    int size = matrix.GetLength(1) * matrix.GetLength(0);

    int[] changeMatrix = new int[size];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            changeMatrix[k] = matrix[i, j];
            k++;
        }
    }
    return changeMatrix;
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
