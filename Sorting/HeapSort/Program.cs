var sourceArray = new [] { 20, 10, 15, 5, 1, 3, 2 };
heapSort(sourceArray);

foreach (var item in sourceArray)
{
    Console.WriteLine(item);
}


void heapSort(int[] array)
{
    for (var i = array.Length / 2 - 1; i >= 0; i--)
    {
        maxHeapify(array, array.Length, i);
    }

    for (var i = array.Length - 1; i > 0; i--)
    {
        (array[i], array[0]) = (array[0], array[i]);
        maxHeapify(array, i, 0);
    }
}

void maxHeapify(int[] array, int heapSize, int index)
{
    var left = 2 * index + 1;
    var right = 2 * index + 2;
    var largest = index;

    if (left < heapSize && array[left] > array[largest])
    {
        largest = left;
    }

    if (right < heapSize && array[right] > array[largest])
    {
        largest = right;
    }

    if (largest != index)
    {
        (array[index], array[largest]) = (array[largest], array[index]);
        maxHeapify(array, heapSize, largest);
    }
}