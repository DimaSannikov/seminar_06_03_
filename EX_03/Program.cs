// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

int[] MakeArray(int len)
{
    int[] array = new int[len];
    for(int i = 0; i < array.Length; i++)
    {
        int num = new Random().Next(-9, 10);
        array[i] = num;
    }
    return array;
}


void SearchElem(int num, int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(num == array[i])
        {
            Console.WriteLine($"Элемент {num} есть в массиве");
        }
    }
}


int[] array = MakeArray(12);
SearchElem(2, array);