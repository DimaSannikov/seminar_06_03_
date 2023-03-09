// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] MakeArray(int dig, int len)
{
    int[] array = new int[len];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(dig);
    }
    return array;
}


int SearchNotEvenPositionsSum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) count += array[i];
    }
    return count;
}


void PrintArray(int[] array)
{
    Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
}


int[] array = MakeArray(10, 4);
PrintArray(array);

int count = SearchNotEvenPositionsSum(array);
Console.WriteLine(count);