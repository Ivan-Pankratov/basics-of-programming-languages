// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
//
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(5, -10, 10);
PrintArray(array);
double result = MaxElementeOfArray(array) - MinElementeOfArray(array);
Console.WriteLine($"Разница максимального и минимального элементов: {result}");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + " ");
        }
        else
        {
            Console.WriteLine(arr[i] + " ]");
        }
    }
}

double MaxElementeOfArray(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinElementeOfArray(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

