// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] myArray = CreateArrayRndInt(7, 1, 10);
int[] newArr = CopyArray(myArray);
newArr[0] = 20;

Console.WriteLine("\nИсходный массив");
PrintArray(myArray);

Console.WriteLine("Новый массив");
PrintArray(newArr);

bool res = Equal(myArray, newArr);
Console.WriteLine(res ? "Равны" : "Не равны");

bool Equal(int[] arr1, int[] arr2)
{
if(arr1.Length != arr2.Length)
{
return false;
}

for (int i = 0; i < arr1.Length; i++)
{
if(arr1[i] != arr2[i])
{
return false;
}
}
return true;
}

int[] CopyArray(int[] array)
{
int[] newArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
newArray[i] = array[i];
}
return newArray;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
int[] array = new int[size];
Random random = new Random();

for(int i = 0; i < array.Length; i++)
{
array[i] = random.Next(min, max +1);
}

return array;
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

int[] CopyArray(int[] arr)
{
int[] copyArray = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
copyArray[i] = arr[i];

}
return copyArray;
}

int[] array = ArrayRndInt(7, 0, 30);
PrintArray(array);

Console.WriteLine();
int[] copyArr = CopyArray(array);
// copyArr[0] = 32; была бы ссылка был бы такой же результат
PrintArray(copyArr);
