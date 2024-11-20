var sourceArray = new [] { 20, 10, 15, 5, 1, 3, 2 };
insertionSort(sourceArray);

foreach (var item in sourceArray)
{
    Console.WriteLine(item);
}


void insertionSort(int[] array)
{
    for (var i = 1; i < array.Length; i++)
    {
        var key = array[i];
        var j = i - 1;

        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            array[j] = key;
            j--;
        }
    }
}