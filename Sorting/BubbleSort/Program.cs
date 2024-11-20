var sourceList = new List<int> { 20, 10, 15, 5, 1, 3, 2 };
var sortedList = bubbleSort(sourceList);

foreach (var item in sortedList)
{
    Console.WriteLine(item);
}


List<int> bubbleSort(List<int> list)
{
    for (var j = 1; j < list.Count; j++)
    {
        var isSorted = true;

        for (var i = 0; i < list.Count - j; i++)
        {
            if (list[i] > list[i + 1])
            {
                (list[i], list[i + 1]) = (list[i + 1], list[i]);
                isSorted = false;
            }
        }

        if (isSorted)
        {
            break;
        }
    }

    return list;
}