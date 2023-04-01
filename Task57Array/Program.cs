// //Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

// Решение с выдачей массива в виде таблицы.

Console.Clear();
int[,] array2d = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(array2d);

int[] array = ChangeMatrix(array2d);

Array.Sort(array);
int[,] result = DictionaryMatrix(array);
PrintDictionaryMatrix(result);

void PrintDictionaryMatrix(int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Частотный словарь массива:");
    Console.WriteLine(" ________________________________");
    Console.WriteLine("| Элемент | Количество повторений|");
    Console.WriteLine("| ________|______________________|");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"|  {array[i, 0],4}   |         {array[i, 1],4}         |");
    }
    Console.WriteLine("``````````````````````````````````");
}

int[,] DictionaryMatrix(int[] array)
{
    int rows = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != array[i - 1]) rows++;
    }
    int[,] dictionary = new int[rows, 2];
    int element = array[0];
    int count = 1;
    rows = 0;
    // dictionary[rows,0] = element;
    // dictionary[rows,1] = count;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == element) count++;
        else
        {
            dictionary[rows, 0] = element;
            dictionary[rows, 1] = count;
            rows++;
            element = array[i];
            count = 1;
        }
    }
    dictionary[rows, 0] = element;
    dictionary[rows, 1] = count;
    return dictionary;
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

