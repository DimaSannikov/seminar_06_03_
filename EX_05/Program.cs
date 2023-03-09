// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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


int[] MakeNewArray(int[] array)
{
    int correctLenArr = array.Length % 2;
    int[] newArray = new int[array.Length / 2 + correctLenArr];
    for(int i = 0; i < array.Length / 2 + correctLenArr; i++)
    {
        if(i < array.Length - 1 - i)
        {
            int dig = array[i] * array[array.Length - 1 - i];
            newArray[i] = dig;
        }
        else
        {
            newArray[i] = array[i];
        }
    }
    return newArray;
}


void PrintArray(int[] array)
{
    Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
}


int[] array = MakeArray(10, 7);
PrintArray(array);

int[] newArray = MakeNewArray(array);
PrintArray(newArray);