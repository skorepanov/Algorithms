var list = new List<int> { 20, 10, 15, 5, 1, 3, 2 };
var sortedList = new List<int>();

for (var i = list.Count - 1; i >= 0; i--)
{
    var smallestIndex = findSmallestIndex(list);
    sortedList.Add(list[smallestIndex]);
    list.RemoveAt(smallestIndex);
}

foreach (var item in sortedList)
{
    Console.WriteLine(item);
}

int findSmallestIndex(List<int> list)
{
    var smallest = list[0];
    var smallestIndex = 0;

    for (var i = 1; i < list.Count; i++)
    {
        if (list[i] < smallest)
        {
            smallest = list[i];
            smallestIndex = i;
        }
    }

    return smallestIndex;
}
