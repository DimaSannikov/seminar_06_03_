// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

double[] MakeArray(int len)
{
    double[] array = new double[len];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 3);
    }
    return array;
}


double FindDifference(double[] array)
{
    double maxElem = array[0];
    double minElem = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxElem) maxElem = array[i];
        if(array[i] < minElem) minElem = array[i];
    }
    double diff = maxElem - minElem;
    return diff;
}


void PrintArray(double[] array)
{
    Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
}


double[] array = MakeArray(10);
PrintArray(array);

double difference = FindDifference(array);
Console.WriteLine(difference);