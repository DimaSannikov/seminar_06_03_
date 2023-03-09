// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

int[] MakeArray(int dig, int len)
{
    int[] array = new int[len];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(dig);
    }
    return array;
}


int FindDifference(int[] array)
{
    int maxElem = array[0];
    int minElem = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxElem) maxElem = array[i];
        if(array[i] < minElem) minElem = array[i];
    }
    int diff = maxElem - minElem;
    return diff;
}


void PrintArray(int[] array)
{
    Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
}


int[] array = MakeArray(100, 10);
PrintArray(array);

int difference = FindDifference(array);
Console.WriteLine(difference);