// Задача 44: Не используя рекурсию, выведите первые N чисел
//  Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayFibonacci(number);
PrintArrayFibonacci(array);


int[] CreateArrayFibonacci(int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i <size; i++)
    {
        array[i] = array[i-2] + array[i-1];
    }
    return array;
}


void PrintArrayFibonacci(int[] array)
{
    int l = array.Length;
    Console.Write($"Первые Числа Фибоначчи для N = {l}: ");
    for (int i = 0; i < l; i++)
    {
        if (i < l - 1)
        {
            Console.Write(array[i] + " ");
        }
        else
        {
            Console.WriteLine(array[i]);
        }
    }
}
