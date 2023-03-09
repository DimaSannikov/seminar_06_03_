// Задайте одномерный массив из 123 случайных чисел. Найдите количество
// элементов массива, значения которых лежат в отрезке [10,99].

int[] MakeArray(int digit, int len)
{
    int[] array = new int[len];
    for(int i = 0; i < array.Length; i++)
    {
        int num = new Random().Next(digit);
        array[i] = num;
    }
    return array;
}


int SearchCount(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 10 & array[i] < 100)
        count++;
    }
    return count;
}


void PrintArray(int[] array)
{
    Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
}


int[] array = MakeArray(200, 123);
PrintArray(array);
Console.WriteLine(SearchCount(array));