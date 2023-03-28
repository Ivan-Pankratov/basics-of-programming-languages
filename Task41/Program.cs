// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// 0, 7, 8, -2, -2 -> 2
//
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число М, где М - количество ваших чисел");
Console.Write("М: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = NewArray(number);
PositiveElements(array);

void PositiveElements(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            n = n + 1;
        }
    }
    Console.WriteLine($"Количество положительных чисел {n}");
}

int[] NewArray(int size)
{
    Console.WriteLine("Введите М чисел (через клавишу ВВОД)");
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
