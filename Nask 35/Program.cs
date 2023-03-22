// 
// Массив с вещественными элементами

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

double[] array = CreateArrayRndDouble(5, 1, 25);
PrintArray(array);