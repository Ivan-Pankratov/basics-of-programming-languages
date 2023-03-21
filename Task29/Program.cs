// Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами
// и выводит их на экран.

int[] array = new int[8];
ArrayGenerator(array);
PrintArray(array);


void PrintArray(int[] arr)
{
     Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("]");
}

int[] ArrayGenerator(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 10);          //генератор случ чисел от 0 до 9
    }
    return arr;
}
