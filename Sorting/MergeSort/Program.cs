var sourceArray = new [] { 20, 10, 15, 5, 1, 3, 2 };
mergeSort(sourceArray);

foreach (var item in sourceArray)
{
    Console.WriteLine(item);
}


void mergeSort(int[] array)
{
    if (array.Length <= 1)
    {
        return;
    }

    var middle = array.Length / 2;

    var left = new int[middle];
    var right = new int[array.Length - middle];

    for (var i = 0; i < middle; i++)
    {
        left[i] = array[i];
    }

    for (var i = middle; i < array.Length; i++)
    {
        right[i - middle] = array[i];
    }

    mergeSort(left);
    mergeSort(right);

    merge(array, left, right);
}

void merge(int[] array, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;

    while (i < left.Length && j < right.Length)
    {
        array[k++] = left[i] <= right[j]
            ? left[i++]
            : right[j++];
    }

    while (i < left.Length)
    {
        array[k++] = left[i++];
    }

    while (j < right.Length)
    {
        array[k++] = right[j++];
    }
}