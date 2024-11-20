var sourceList = new [] { 20, 10, 15, 5, 1, 3, 2 };
mergeSort(sourceList);

foreach (var item in sourceList)
{
    Console.WriteLine(item);
}


void mergeSort(int[] list)
{
    if (list.Length <= 1)
    {
        return;
    }

    var middle = list.Length / 2;

    var left = new int[middle];
    var right = new int[list.Length - middle];

    for (var i = 0; i < middle; i++)
    {
        left[i] = list[i];
    }

    for (var i = middle; i < list.Length; i++)
    {
        right[i - middle] = list[i];
    }

    mergeSort(left);
    mergeSort(right);

    merge(list, left, right);
}

void merge(int[] list, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;

    while (i < left.Length && j < right.Length)
    {
        list[k++] = left[i] <= right[j]
            ? left[i++]
            : right[j++];
    }

    while (i < left.Length)
    {
        list[k++] = left[i++];
    }

    while (j < right.Length)
    {
        list[k++] = right[j++];
    }
}