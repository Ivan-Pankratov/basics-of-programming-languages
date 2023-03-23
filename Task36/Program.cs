// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
//
// [3, 7, 23, 12] -> 19
//
// [-4, -6, 89, 6] -> 0

int[] array = GreatArrayRndInt(9, 1, 30);
PrintArray(array);
Console.WriteLine();

int result = SumOddElementsArray(array);
Console.WriteLine($"Сумма нечётных элементов: {result}");

int[] GreatArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumOddElementsArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
