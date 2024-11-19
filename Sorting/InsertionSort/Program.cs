var sourceList = new List<int> { 20, 10, 15, 5, 1, 3, 2 };
var sortedList = insertionSort(sourceList);

foreach (var item in sortedList)
{
    Console.WriteLine(item);
}


List<int> insertionSort(List<int> list)
{
    for (var i = 1; i < list.Count; i++)
    {
        var key = list[i];
        var j = i - 1;

        while (j >= 0 && list[j] > key)
        {
            list[j + 1] = list[j];
            list[j] = key;
            j--;
        }
    }

    return list;
}