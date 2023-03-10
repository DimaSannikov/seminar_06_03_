int[] MakeArray(int maxInArr)
{
    int[] array = new int[maxInArr - 2];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = i + 2;
    }
    return array;
}


int[] MakeSimpleNumbersArray(int[] array)
{
    int[] arraySimple = new int[1];
    arraySimple[0] = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        int vary = 0;
        int j = 0;
        while(j < arraySimple.Length)
        {
            if(array[i] % arraySimple[j] != 0) vary = 1;
            else
            {
                vary = 0;
                j = arraySimple.Length;
            }
            j++;
        }
        if(vary == 1)
        {
            Array.Resize(ref arraySimple, arraySimple.Length + 1);
            arraySimple[arraySimple.Length - 1] = array[i];
        }
    }
    return arraySimple;
}


int[] array = MakeArray(1000);
// Console.WriteLine("["+$"{String.Join(", ", array)}"+"]");
// Console.WriteLine(array.Length);

int[] arraySimple = MakeSimpleNumbersArray(array);
Console.WriteLine("["+$"{String.Join(", ", arraySimple)}"+"]");
Console.WriteLine(arraySimple.Length);
