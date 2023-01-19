// Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
using static System.Console;
Clear();

int[] array = GetArray(10);
PrintArray(array);
int count = countOddNumber(array);
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

int countOddNumber(int[] inArray)
{
    int result = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (i % 2 != 0) 
        {
            result += inArray[i];
        }  
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