//  Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.Write("Введите целое число, a =  ");
int a = Convert.ToInt32(Console.ReadLine());

int product = Product(a);
Console.WriteLine($"Произведение чисел от 1 до {a} = {product}");

int Product(int num)
{
    int prod = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            prod = prod * i;
        }
    }
    return prod;
}



