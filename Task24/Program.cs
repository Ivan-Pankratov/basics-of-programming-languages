//  Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
//

Console.Write("Введите целое число, a =  ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {number} = {SumNumbers(number)}");

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;   //sum = sum+i;
    }
    return sum;
}