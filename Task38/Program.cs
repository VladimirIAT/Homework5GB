// Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами и 
//вычисления разницы между максимальным и минимальным элементов массива.
//[3,3 7,1 22,5 2,2 78,2] -> 76
using static System.Console;
Clear();

int[] array = GetArray(10);
PrintArray(array);
int count = findMinMax(array);
Write(count);

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(0, 10);
    }
    return resultArray;
}

int findMinMax(int[] inArray)
{
    int minNum = inArray[0];
    int maxNum = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] < minNum) 
        {
            minNum = inArray[i + 1];
        }
        if (inArray[i] > maxNum) 
        {
            maxNum = inArray[i];
        }
    }
    int result = maxNum - minNum;
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