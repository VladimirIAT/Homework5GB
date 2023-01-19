// Напишите программу реализующую методы формирования массива, заполненного случайными положительными 
//трёхзначными числами, и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
using static System.Console;
Clear();

int[] array = GetArray(10);
PrintArray(array);
int count = countNumber(array);
Write(count);

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(100, 999);
    }
    return resultArray;
}

int countNumber(int[] inArray)
{
    int result = 0;
    foreach (int i in inArray)
    {
        if (i % 2 == 0) result++;
    }
    return result;
}

void PrintArray(int[] inArray)
{
    Write("[");
        for (int i = 0; i < inArray.Length - 1; i++)
            {
                Write($"{inArray[i]},");
            }
    Write($"{inArray[inArray.Length - 1]}]");
}