// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

///// к задаче 60

int[,,] array3D = CreateArray3DSequenceInt(4, 3, 2);
PrintArray3D (array3D);

int[,,] CreateArray3DSequenceInt(int rows, int columns, int depth)
{                          
    int[,,] matrix = new int[rows, columns, depth];
    int number = rows*columns*depth+10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = number;
                number--;
            }
        }
    }
    return matrix;
}

void PrintArray3D (int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i,j,k],4}");
                Console.Write($"({i},{j},{k}) ");
            }

        }
        Console.WriteLine();
    }
}
