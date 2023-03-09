// Напишите программу замена элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] MakeArray(int len)
{
    int[] array = new int[len];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}


int[] ChangeSignInArrElem(int[] array)
{
    int[] newArray = array;
    int negDigit = -1;
    for(int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = newArray[i] * negDigit;
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
}


int[] arr = MakeArray(12);
PrintArray(arr);

int[] newArr = ChangeSignInArrElem(arr);
PrintArray(newArr);