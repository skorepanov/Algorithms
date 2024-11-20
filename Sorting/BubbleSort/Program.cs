var sourceArray = new [] { 20, 10, 15, 5, 1, 3, 2 };
bubbleSort(sourceArray);

foreach (var item in sourceArray)
{
    Console.WriteLine(item);
}


void bubbleSort(int[] array)
{
    for (var j = 1; j < array.Length; j++)
    {
        var isSorted = true;

        for (var i = 0; i < array.Length - j; i++)
        {
            if (array[i] > array[i + 1])
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
                isSorted = false;
            }
        }

        if (isSorted)
        {
            break;
        }
    }
}